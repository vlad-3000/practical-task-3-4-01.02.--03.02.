namespace задание_3;
    using Npgsql;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

public partial class Form1 : Form
{
    private string connectionString = "Host=localhost; Port=5432 ; Database=R7-571 ; Username=postgres; Password=780213;";
    private int doom = 0;
    public Form1()
    {
        InitializeComponent();
    }

    
    private bool UserExists(string username)
    {
        bool userExists = false;


        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();


            string sql = "SELECT COUNT(*) FROM логин_пароль WHERE логин = @login";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@login", username);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    userExists = true;
                }
            }
        }

        return userExists;
    }
    private bool ValidatePassword(string password)
    {
        bool letters = false;
        bool numbers = false;
        bool signs = false;
        string symb1 = "ABCDEFGHIJKLMNOPRSTUVWXYZqwertyuiopasdfghjklzxcvbnmйцукенгшщзхъфывапролджэячсмитьбюЙЦУКЕНГШЩЗХЪЭЖДЛОРПАВЫФЯЧСМИТЬБЮ";
        string symb2 = "1234567890";
        string symb = "@,!";
        foreach (char c in password)
        {

            if (symb1.Contains(c))
            {
                letters = true;
            }
            else if (symb2.Contains(c))
            {
                numbers = true;
            }
            else if (symb.Contains(c))
            {
                signs = true;
            }
        }

        return letters && numbers && signs;
    }

    private string AuthenticateUser(string username, string password)
    {
        string role = "";

        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();

            NpgsqlCommand command = new NpgsqlCommand("SELECT роль FROM логин_пароль WHERE логин = @username AND пароль = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            using (NpgsqlDataReader reader = command.ExecuteReader())

            {
                if (reader.Read())
                {
                    role = reader.GetString(0);
                }
            }
        }

        return role;
    }


    private void registrationButton_Click(object sender, EventArgs e)
    {
        string username = loginBox.Text;
        string password = passBox.Text;

        if (UserExists(username))
        {
            MessageBox.Show("Пользователь с таким именем уже существует!");
            return;
        }
        else if (username.Length < 4)
        {
            MessageBox.Show("логин слишком короткий");
            return;
        }


        if (password.Length < 8)
        {
            MessageBox.Show("пароль слишком короткий");
            return;
        }
        else if (!ValidatePassword(password))
        {
            MessageBox.Show("Пароль не соответствует требованиям! пароль должен содержать буквы, цифры и символы (@,!)");
            return;
        }

       
        using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        {
            connection.Open();


            string sql = "INSERT INTO логин_пароль (логин, пароль, роль) VALUES (@login, @pass, @normal)";

            using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
            {

                command.Parameters.AddWithValue("@login", username);
                command.Parameters.AddWithValue("@pass", password);
                command.Parameters.AddWithValue("@normal", "normal");

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Регистрация успешно завершена!");
                    loginBox.Clear();
                    passBox.Clear();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации!");
                }
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        string username = loginBox.Text;
        string password = passBox.Text;
        string role = AuthenticateUser(username, password);


        
        if (role == "admin")
        {
            Admin grin = new Admin();
            grin.Show();
        }
        else if (role == "manager")
        {
           Manager red = new Manager(); 
            red.Show();
        }
        else if (role == "normal")
        {
            MessageBox.Show("Вы вошли как пользователь-" + username);
        }
        else
        {
            doom++;
            if (doom >= 3)
            {
                MessageBox.Show("через 20 секунд вы сможете попробовать еще раз");
                button2.Enabled = false;
                Thread.Sleep(20000);
                button2.Enabled = true;
                doom = 0;
            }
            else
            {
                MessageBox.Show("Ошибка входа");
            }
                
        }
       
    }

}
    


