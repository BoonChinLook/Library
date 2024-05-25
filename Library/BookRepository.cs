using MySql.Data.MySqlClient;

public class BookRepository
{
    private Database _database;

    public BookRepository()
    {
        _database = new Database();
    }

    public void AddBook(Book book)
    {
        using (MySqlConnection conn = _database.GetConnection())
        {
            conn.Open();

            string query = "INSERT INTO book (title, author) VALUES (@Title, @Author)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                

                cmd.ExecuteNonQuery();
            }
        }
    }
}
