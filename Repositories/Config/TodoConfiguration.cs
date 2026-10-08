using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.VisualBasic;
using TodoApp.Models;

namespace TodoApp.Repositories.Config
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todos");

            builder.HasKey(t => t.Id);

            builder.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .HasMaxLength(100);

            builder.Property(x => x.Priority)
                .HasConversion<int>()
                .HasDefaultValue(TodoPriority.Low)
                .IsRequired();

            builder.Property(x => x.IsDone)
                .HasDefaultValue(false)
                .IsRequired();

            builder.HasIndex(x => x.DueDate);
            builder.HasIndex(x => x.Priority);
            builder.HasIndex(x => x.IsDone);

            var today = DateTime.Today;
            builder.HasData(
                new Todo
                {
                    Id = Guid.Parse("f3b5a1d2-1c9b-4f2e-9e2a-8a1b2c3d4e5f"),
                    Title = "Buy groceries",
                    Description = "Milk, eggs, bread",
                    DueDate = today.AddDays(1),
                    Priority = TodoPriority.Medium,
                    IsDone = false
                },
                new Todo
                {
                    Id = Guid.Parse("a2c4e6f8-9b7d-4a3c-8f1e-0d9c8b7a6e5d"),
                    Title = "Finish project report",
                    Description = "Complete the summary and send to manager",
                    DueDate = today.AddDays(3),
                    Priority = TodoPriority.High,
                    IsDone = false
                },
                new Todo
                {
                    Id = Guid.Parse("c0b1a2d3-e4f5-6789-abcd-0123456789ab"),
                    Title = "Call plumber",
                    Description = "Fix kitchen sink leak",
                    DueDate = today.AddDays(7),
                    Priority = TodoPriority.Low,
                    IsDone = false
                },
                new Todo
                {
                    Id = Guid.Parse("d4e5f6a7-b8c9-4d3e-9f0a-1234abcd5678"),
                    Title = "Read book",
                    Description = "Read 50 pages of the new novel",
                    DueDate = today.AddDays(14),
                    Priority = TodoPriority.Low,
                    IsDone = true
                }
                );
        }
    }
}
