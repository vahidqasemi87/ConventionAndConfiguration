// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Part01.DataAccess;

namespace Part01.Migrations
{
    [DbContext(typeof(ConfigContext))]
    [Migration("20210325103111_init17")]
    partial class init17
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Part01.Models.Index.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FactoryNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FactoryNo", "Name");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Part01.Models.Not_Primary_Key.Animal", b =>
                {
                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Animals");
                });

            modelBuilder.Entity("Part01.Models.Not_Primary_Key.AnimalView", b =>
                {
                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.ToView("vw_AnimalView");
                });

            modelBuilder.Entity("Part01.Models.PersonAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DATETIME2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("FName");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR(5)")
                        .HasColumnName("LName");

                    b.HasKey("Id");

                    b.ToTable("PersonAttributes");
                });

            modelBuilder.Entity("Part01.Models.PersonCon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PersonCons");
                });

            modelBuilder.Entity("Part01.Models.PersonFluent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasPrecision(10, 4)
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("DateTime");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("FName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("NVARCHAR(46)")
                        .HasColumnName("LName");

                    b.Property<string>("NationalCode")
                        .HasColumnType("NVARCHAR(10)")
                        .HasColumnName("NCode");

                    b.Property<string>("PersonType")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)")
                        .HasColumnName("PType");

                    b.HasKey("Id");

                    b.ToTable("PersonFluents");
                });

            modelBuilder.Entity("Part01.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EncryctionText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Part01.Models.Teacher", b =>
                {
                    b.Property<int>("My_Primary_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("Datetime");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("FName");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("LName");

                    b.HasKey("My_Primary_Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("Part01.Models.TeacherFluent", b =>
                {
                    b.Property<int>("My_Primary_Key01")
                        .HasColumnType("int");

                    b.Property<int>("My_Primary_Key02")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true)
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("FName");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("NVARCHAR(50)")
                        .HasColumnName("LName");

                    b.HasKey("My_Primary_Key01", "My_Primary_Key02");

                    b.ToTable("TeacherFluent");
                });
#pragma warning restore 612, 618
        }
    }
}
