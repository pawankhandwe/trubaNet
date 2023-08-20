namespace BlogManagmentSystem.Models
{
    public class Comment
    {
      
            public int Id { get; set; }
            public string Content { get; set; }

            // Foreign key for the one-to-many relationship
            public int BlogId { get; set; }

            // Navigation property for the one-to-many relationship
            public Blog Blog { get; set; }
        
    }


}
