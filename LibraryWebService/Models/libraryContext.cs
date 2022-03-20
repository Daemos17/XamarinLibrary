using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace LibraryWebService.Models
{
    public partial class libraryContext : DbContext
    {
        public libraryContext()
        {
        }

        public libraryContext(DbContextOptions<libraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<LibrariesBook> LibrariesBooks { get; set; }
        public virtual DbSet<Library> Libraries { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentsBook> StudentsBooks { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=library;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Author>(entity =>
            {
                entity.HasKey(e => e.IdAuthor);

                entity.Property(e => e.IdAuthor)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_author");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(e => e.IdBook);

                entity.Property(e => e.IdBook)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_book");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Bookname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdAuthorFk).HasColumnName("Id_authorFk");

                entity.Property(e => e.IdGenreFk).HasColumnName("id_genreFk");

                entity.Property(e => e.IdTypeFk).HasColumnName("id_typeFk");

                entity.Property(e => e.ImageCode)
                    .HasColumnType("image")
                    .HasColumnName("imageCode");

                entity.Property(e => e.Year)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("year");

                entity.HasOne(d => d.IdAuthorFkNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdAuthorFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Books_Authors");

                entity.HasOne(d => d.IdGenreFkNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdGenreFk)
                    .HasConstraintName("FK_Books_Genres");

                entity.HasOne(d => d.IdTypeFkNavigation)
                    .WithMany(p => p.Books)
                    .HasForeignKey(d => d.IdTypeFk)
                    .HasConstraintName("FK_Books_Types");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.HasKey(e => e.IdGenre);

                entity.Property(e => e.IdGenre)
                    .ValueGeneratedNever()
                    .HasColumnName("id_genre");

                entity.Property(e => e.GenreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genreName");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.IdGroup);

                entity.Property(e => e.IdGroup)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_group");

                entity.Property(e => e.GroupAlias)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("groupAlias");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("groupName");
            });

            modelBuilder.Entity<LibrariesBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Libraries-Books");

                entity.Property(e => e.IdBookLbFk).HasColumnName("id_bookLbFk");

                entity.Property(e => e.IdLibraryFk).HasColumnName("id_libraryFk");

                entity.HasOne(d => d.IdBookLbFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBookLbFk)
                    .HasConstraintName("FK_Libraries-Books_Books");

                entity.HasOne(d => d.IdLibraryFkNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdLibraryFk)
                    .HasConstraintName("FK_Libraries-Books_Libraries");
            });

            modelBuilder.Entity<Library>(entity =>
            {
                entity.HasKey(e => e.IdLibrary);

                entity.Property(e => e.IdLibrary)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_library");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LibraryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.IdPerson);

                entity.Property(e => e.IdPerson)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_person");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdStudent);

                entity.Property(e => e.IdStudent)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_student");

                entity.Property(e => e.IdGroupFk).HasColumnName("id_group(fk)");

                entity.Property(e => e.IdPersStudFk).HasColumnName("Id_pers_Stud(Fk)");

                entity.Property(e => e.Year)
                    .HasMaxLength(10)
                    .HasColumnName("year")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdGroupFkNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdGroupFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Groups");

                entity.HasOne(d => d.IdPersStudFkNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.IdPersStudFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students_Persons");
            });

            modelBuilder.Entity<StudentsBook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Students-Books");

                entity.Property(e => e.DateofPicking)
                    .HasColumnType("date")
                    .HasColumnName("dateofPicking");

                entity.Property(e => e.DateofRetruning)
                    .HasColumnType("date")
                    .HasColumnName("dateofRetruning");

                entity.Property(e => e.IdBookS).HasColumnName("id_bookS");

                entity.Property(e => e.IdStudentS).HasColumnName("id_studentS");

                entity.HasOne(d => d.IdBookSNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdBookS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students-Books_Books");

                entity.HasOne(d => d.IdStudentSNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdStudentS)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Students-Books_Students");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.IdType);

                entity.Property(e => e.IdType)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_type");

                entity.Property(e => e.TypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.IdWorker);

                entity.Property(e => e.IdWorker)
                    .ValueGeneratedNever()
                    .HasColumnName("Id_worker");

                entity.Property(e => e.IdPersWorkFk).HasColumnName("Id_pers_Work(fk)");

                entity.Property(e => e.Position)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersWorkFkNavigation)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.IdPersWorkFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Workers_Persons");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
