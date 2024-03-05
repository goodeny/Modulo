using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.ComponentModel.Design;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

public class Faculdade
{
    public static void Main(string[] args)
    {
        Faculdade menu = new Faculdade();
        menu.Menu();
    }
    public void Menu()
    {
        Console.WriteLine(@"
         _____ ______   ________  ________  ___  ___  ___       ________     
        |\   _ \  _   \|\   __  \|\   ___ \|\  \|\  \|\  \     |\   __  \    
        \ \  \\\__\ \  \ \  \|\  \ \  \_|\ \ \  \\\  \ \  \    \ \  \|\  \   
         \ \  \\|__| \  \ \  \\\  \ \  \ \\ \ \  \\\  \ \  \    \ \  \\\  \  
          \ \  \    \ \  \ \  \\\  \ \  \_\\ \ \  \\\  \ \  \____\ \  \\\  \ 
           \ \__\    \ \__\ \_______\ \_______\ \_______\ \_______\ \_______\
            \|__|     \|__|\|_______|\|_______|\|_______|\|_______|\|_______|                                                         
        ");
        Aluno aluno = new Aluno();
        Biblioteca biblioteca = new Biblioteca();

        while (true) {   
            Console.WriteLine("------ MENU ------\n[1] Mostrar todos os alunos\n[2] Cadastrar Aluno\n[3] Atualizar dados do aluno\n[4] Deletar Alunos\n------------------\n[5] Mostrar todos os livros\n[6] Adicionar um novo livro\n[7] Atualizar livro\n[8] Deletar livro\n\nEscolha uma opção: ");
            string choose = Console.ReadLine();   
            switch (Convert.ToInt16(choose))
            {
                
                case 1:
                    aluno.SelectAll();
                    break;
                case 2:
                    Console.WriteLine("Digite o nome do Aluno: ");
                    string nome = Console.ReadLine();
                    Console.WriteLine("Digite o RGM do Aluno: ");
                    string RGM = Console.ReadLine();
                    Console.WriteLine("Digite a Data de nasicmento do Aluno: ");
                    string DataNascimento = Console.ReadLine();
                    Console.WriteLine("Digite o curso do Aluno: ");
                    string Curso = Console.ReadLine();
                    Console.WriteLine("Digite se o aluno é bolsista ou não [s/n]: ");
                    string Bolsista = Console.ReadLine();
                    Console.WriteLine("Digite o RG do Aluno: ");
                    string RG = Console.ReadLine();
                    Console.WriteLine("Digite o Genero do Aluno: ");
                    string Genero = Console.ReadLine();
                    aluno.Insert(nome, RGM, DataNascimento, Curso, Bolsista, RG, Genero);
                    break;
                case 3:
                    aluno.SelectAll();
                    Console.WriteLine("Digite o ID do aluno que deseja atualizar: ");
                    string update_id = Console.ReadLine();
                    Console.WriteLine("Digite o Novo nome do aluno: (Se não precisar aperte <ENTER>)");
                    string update_name = Console.ReadLine();
                    Console.WriteLine("Digite o Novo RGM do aluno: (Se não precisar aperte <ENTER>)");
                    string update_RGM = Console.ReadLine();
                    Console.WriteLine("Digite a Nova data de nascimento do aluno: (Se não precisar aperte <ENTER>)");
                    string update_DataNascimento = Console.ReadLine();
                    Console.WriteLine("Digite o Novo curso do aluno: (Se não precisar aperte <ENTER>)");
                    string update_curso = Console.ReadLine();
                    Console.WriteLine("Digite se o Aluno é bolsista? [Sim/Não]: (Se não precisar aperte <ENTER>)");
                    string update_Bolsista = Console.ReadLine();
                    Console.WriteLine("Digite o RG do aluno: (Se não precisar aperte <ENTER>)");
                    string update_RG = Console.ReadLine();
                    Console.WriteLine("Digite o novo Genero do aluno: (Se não precisar aperte <ENTER>)");
                    string update_genero = Console.ReadLine();
                    aluno.Update(Convert.ToInt16(update_id),update_name, update_RGM, update_DataNascimento, update_curso, update_Bolsista, update_RG, update_genero);
                    break;
                case 4:
                    aluno.SelectAll();
                    Console.WriteLine("Digite o ID do aluno que deseja excluir: ");
                    string id = Console.ReadLine();
                    aluno.Delete(Convert.ToInt16(id));
                    break;
                case 5:
                    biblioteca.SelectAll();
                    break;
                case 6:
                    Console.WriteLine("Digite o ISBN do Livro: ");
                    string book_ISBN = Console.ReadLine();
                    Console.WriteLine("Digite o Titulo do Livro: ");
                    string book_titulo = Console.ReadLine();
                    Console.WriteLine("Digite o Autor do Livro: ");
                    string book_autor = Console.ReadLine();
                    Console.WriteLine("Digite o Ano do Livro: ");
                    string book_ano = Console.ReadLine();
                    Console.WriteLine("Digite o Genero do Livro: ");
                    string book_genero = Console.ReadLine();
                    Console.WriteLine("Digite o Edição do Livro: ");
                    string book_edicao = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade de Livro: ");
                    string book_quantity = Console.ReadLine();
                    biblioteca.Insert(book_ISBN, book_titulo, book_autor, Convert.ToInt32(book_ano), book_genero, book_edicao, Convert.ToInt32(book_quantity));
                    break;
                case 7:
                    biblioteca.SelectAll();
                    Console.WriteLine("Digite o ID do livro que deseja atualizar: ");
                    string update_book_id = Console.ReadLine();
                    Console.WriteLine("Digite o novo ISBN do Livro: Se não precisar pressione<ENTER>");
                    string update_book_ISBN = Console.ReadLine();
                    Console.WriteLine("Digite o novo Titulo do Livro: Se não precisar pressione<ENTER>");
                    string update_book_titulo = Console.ReadLine();
                    Console.WriteLine("Digite o novo Autor do Livro: Se não precisar pressione<ENTER>");
                    string update_book_autor = Console.ReadLine();
                    Console.WriteLine("Digite o novo Ano do Livro: Se não precisar pressione<ENTER>");
                    string update_book_ano = Console.ReadLine();
                    Console.WriteLine("Digite o novo Genero do Livro: Se não precisar pressione<ENTER>");
                    string update_book_genero = Console.ReadLine();
                    Console.WriteLine("Digite o novo Edicao do Livro: Se não precisar pressione<ENTER>");
                    string update_book_edicao = Console.ReadLine();
                    Console.WriteLine("Digite a nova Quantidade de Livro: Se não precisar pressione<ENTER>");
                    string update_book_quantity = Console.ReadLine();
                    biblioteca.Update(Convert.ToInt16(update_book_id), update_book_ISBN, update_book_titulo, update_book_autor, Convert.ToInt32(update_book_ano), update_book_genero, update_book_edicao, Convert.ToInt32(update_book_quantity));
                    break;
                case 8:
                    biblioteca.SelectAll();
                    Console.WriteLine("Digite o ID do livro que deseja excluir: ");
                    string book_id = Console.ReadLine();
                    biblioteca.Delete(Convert.ToInt16(book_id));
                    break;
            }
        }
    }
}
public class Database
{
    public MySql.Data.MySqlClient.MySqlConnection DatabaseExec()
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        myConnectionString = "server=localhost;uid=root;" + "pwd=;database=Faculdade";

        conn = new MySql.Data.MySqlClient.MySqlConnection();
        conn.ConnectionString = myConnectionString;
        conn.Open();

        return conn;
    }
}
public class Aluno
{
    Database database = new Database();
    public void SelectAll()
    {
        try
        {  
            string query = "SELECT * from User";
            MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt16(0);
                string nome = reader.GetString(1);
                string RGM = reader.GetString(2);
                string DataNascimento = reader.GetString(3);
                string Curso = reader.GetString(4);
                string Bolsista = reader.GetString(5);
                string RG = reader.GetString(6);
                string Genero = reader.GetString(6);

                Console.WriteLine($"ID: {id} Nome: {nome} Endereço: {RGM} Data Nascimento: {DataNascimento} Curso: {Curso} Bolsista: {Bolsista} RG: {RG} Genero: {Genero}");
            }
            reader.Close();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void Insert(string nome, string RGM, string DataNascimento, string Curso, string Bolsista, string RG, string Genero)
    {
        try
        {
            string query = $"insert into User (nome, RGM, DataNascimento, Curso, Bolsista, RG, Genero) values ('{nome}','{RGM}','{DataNascimento}','{Curso}','{Bolsista}','{RG}','{Genero}')";
            MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Close();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void Delete(int id)
    {
        try
        {
            string query = $"DELETE FROM User WHERE (id = {id})";
            MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Close();

            Console.WriteLine($"Aluno com o ID: {id} foi deletado com sucesso!");
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    public void Update(int id, string nome, string RGM, string DataNascimento, string Curso, string Bolsista, string RG, string Genero)
    {
        if (nome  == ""){
            Console.WriteLine("");
        } else {
            try
            {
                string query = $"UPDATE User set nome = '{nome}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"O nome do aluno com o ID: {id} foi alterado com sucesso!");
            }
                catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        if (RGM == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE User set RGM = '{RGM}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"O RGM do aluno com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        if (DataNascimento == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE User set DataNascimento = '{DataNascimento}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"A data de nascimento do aluno com o ID: {id} foi alterada com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        if (Curso == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE User set Curso = '{Curso}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"O Curso do aluno com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        if (Bolsista == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE User set Bolsista = {Bolsista} WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"A bolsa do aluno com o ID: {id} foi alterada com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        if (RG == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE User set RG = '{RG}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"O RG do aluno com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        if (Genero == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE User set Genero = '{Genero}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();

                Console.WriteLine($"O Genero do aluno com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

public class Biblioteca
{
    Database database = new Database();
    public void SelectAll()
    {
        try
        {
            string query = $"SELECT * from Library";
            MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt16(0);
                string ISBN = reader.GetString(1);
                string Titulo = reader.GetString(2);
                string Autor = reader.GetString(3);
                int Ano = reader.GetInt16(4);
                string Genero = reader.GetString(5);
                string Edicao = reader.GetString(6);
                int Quantidade = reader.GetInt32(7);

                Console.WriteLine($"ID: {id} ISBN do livro: {ISBN} Titulo: {Titulo} Autor: {Autor} Ano {Ano} Genero {Genero} Edicao {Edicao} Quantidade: {Quantidade}");
            }
            reader.Close();
        } catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Insert(string ISBN, string Titulo, string Autor, int Ano, string Genero, string Edicao, int Quantidade)
    {
        try
        {
            string query = $"insert into Library (ISBN, Titulo, Autor, Ano, Genero, Edicao, Quantidade) values ('{ISBN}','{Titulo}','{Autor}','{Ano}','{Genero}','{Edicao}','{Quantidade}')";
            MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Close();
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Delete(int id)
    {
        try
        {
            string query = $"DELETE FROM Library WHERE (id = {id})";
            MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
            MySqlDataReader reader = cmd.ExecuteReader();

            reader.Close();

            Console.WriteLine($"O livro com o ID: {id} foi deletado com sucesso!");
        }
        catch (MySql.Data.MySqlClient.MySqlException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void Update(int id, string ISBN, string Titulo, string Autor, int Ano, string Genero, string Edicao, int Quantidade)
    {
        if (ISBN == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set ISBN = '{ISBN}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"O ISBN do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (Titulo == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set Titulo = '{Titulo}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"O Titulo do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (Autor == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set Autor = '{Autor}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"O Autor do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (Ano == null)
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set Ano = '{Ano}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"O Ano do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (Genero == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set Genero = '{Genero}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"O Genero do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (Edicao == "")
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set Edicao = '{Edicao}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"O Genero do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (Quantidade == null)
        {
            Console.WriteLine("");
        }
        else
        {
            try
            {
                string query = $"UPDATE Library set Quantidade = '{Quantidade}' WHERE id = {id}";
                MySqlCommand cmd = new MySqlCommand(query, database.DatabaseExec());
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                Console.WriteLine($"A Quantidade do livro com o ID: {id} foi alterado com sucesso!");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
