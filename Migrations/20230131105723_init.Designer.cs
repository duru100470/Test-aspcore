// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Testaspcore.Migrations
{
    [DbContext(typeof(TodoDb))]
    [Migration("20230131105723_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
