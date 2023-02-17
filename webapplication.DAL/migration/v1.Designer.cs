using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using webapplication.DAL.database;

namespace webapplication.DAL.migration
{
    [DbContext(typeof(mydbcontext))]
    [Migration("20221228194820_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("kidsschoolproject.Models.Communications", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Date")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Day")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("Idstudent")
                    .HasColumnType("int");

                b.Property<int>("idlecture")
                    .HasColumnType("int");

                b.Property<string>("text")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("Idstudent");

                b.HasIndex("idlecture");

                b.ToTable("Communications");
            });

            modelBuilder.Entity("kidsschoolproject.Models.admin", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("birthday")
                    .HasColumnType("int");

                b.Property<string>("description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("gender")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("phone")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("photo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("admin");
            });

            modelBuilder.Entity("kidsschoolproject.Models.course", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<double>("coast")
                    .HasColumnType("float");

                b.Property<int>("idlecture")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("idlecture");

                b.ToTable("course");
            });

            modelBuilder.Entity("kidsschoolproject.Models.lectuerstudent", b =>
            {
                b.Property<int>("idstudent")
                    .HasColumnType("int");

                b.Property<int>("idlectuer")
                    .HasColumnType("int");

                b.HasKey("idstudent", "idlectuer");

                b.HasIndex("idlectuer");

                b.ToTable("lectuerstuden");
            });

            modelBuilder.Entity("kidsschoolproject.Models.lecture", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("birthday")
                    .HasColumnType("int");

                b.Property<string>("description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("gender")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("phone")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("photo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.ToTable("lecture");
            });

            modelBuilder.Entity("kidsschoolproject.Models.parent", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("birthday")
                    .HasColumnType("int");

                b.Property<string>("description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("gender")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("phone")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("photo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("studentcode")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.ToTable("parent");
            });

            modelBuilder.Entity("kidsschoolproject.Models.session", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("idcourse")
                    .HasColumnType("int");

                b.Property<int>("idlecture")
                    .HasColumnType("int");

                b.Property<string>("linkviedo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("sessiontime")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("idcourse");

                b.HasIndex("idlecture");

                b.ToTable("session");
            });

            modelBuilder.Entity("kidsschoolproject.Models.student", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("birthday")
                    .HasColumnType("int");

                b.Property<string>("description")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("email")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("gender")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<int>("idparent")
                    .HasColumnType("int");

                b.Property<string>("password")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("phone")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("photo")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("idparent");

                b.ToTable("student");
            });

            modelBuilder.Entity("kidsschoolproject.Models.student_cource", b =>
            {
                b.Property<int>("idstudent")
                    .HasColumnType("int");

                b.Property<int>("idcourse")
                    .HasColumnType("int");

                b.HasKey("idstudent", "idcourse");

                b.HasIndex("idcourse");

                b.ToTable("student_cource");
            });

            modelBuilder.Entity("kidsschoolproject.Models.tasks", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Idlecture")
                    .HasColumnType("int");

                b.Property<int>("Idstudent")
                    .HasColumnType("int");

                b.Property<string>("linkform")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("title")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.HasKey("Id");

                b.HasIndex("Idlecture");

                b.HasIndex("Idstudent");

                b.ToTable("tasks");
            });

            modelBuilder.Entity("kidsschoolproject.Models.Communications", b =>
            {
                b.HasOne("kidsschoolproject.Models.student", "student")
                    .WithMany("Communications")
                    .HasForeignKey("Idstudent")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("kidsschoolproject.Models.lecture", "lecture")
                    .WithMany("Communications")
                    .HasForeignKey("idlecture")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("lecture");

                b.Navigation("student");
            });

            modelBuilder.Entity("kidsschoolproject.Models.course", b =>
            {
                b.HasOne("kidsschoolproject.Models.lecture", "lecture")
                    .WithMany("course")
                    .HasForeignKey("idlecture")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("lecture");
            });

            modelBuilder.Entity("kidsschoolproject.Models.lectuerstudent", b =>
            {
                b.HasOne("kidsschoolproject.Models.lecture", "lecture")
                    .WithMany("lectuerstudent")
                    .HasForeignKey("idlectuer")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("kidsschoolproject.Models.student", "student")
                    .WithMany("lectuerstudent")
                    .HasForeignKey("idstudent")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("lecture");

                b.Navigation("student");
            });

            modelBuilder.Entity("kidsschoolproject.Models.session", b =>
            {
                b.HasOne("kidsschoolproject.Models.course", "course")
                    .WithMany("session")
                    .HasForeignKey("idcourse")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("kidsschoolproject.Models.lecture", "lecture")
                    .WithMany("session")
                    .HasForeignKey("idlecture")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("course");

                b.Navigation("lecture");
            });

            modelBuilder.Entity("kidsschoolproject.Models.student", b =>
            {
                b.HasOne("kidsschoolproject.Models.parent", "parent")
                    .WithMany("student")
                    .HasForeignKey("idparent")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("parent");
            });

            modelBuilder.Entity("kidsschoolproject.Models.student_cource", b =>
            {
                b.HasOne("kidsschoolproject.Models.course", "course")
                    .WithMany("student_Cources")
                    .HasForeignKey("idcourse")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("kidsschoolproject.Models.student", "student")
                    .WithMany("student_Cources")
                    .HasForeignKey("idstudent")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("course");

                b.Navigation("student");
            });

            modelBuilder.Entity("kidsschoolproject.Models.tasks", b =>
            {
                b.HasOne("kidsschoolproject.Models.lecture", "lecture")
                    .WithMany("tasks")
                    .HasForeignKey("Idlecture")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("kidsschoolproject.Models.student", "student")
                    .WithMany("tasks")
                    .HasForeignKey("Idstudent")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("lecture");

                b.Navigation("student");
            });

            modelBuilder.Entity("kidsschoolproject.Models.course", b =>
            {
                b.Navigation("session");

                b.Navigation("student_Cources");
            });

            modelBuilder.Entity("kidsschoolproject.Models.lecture", b =>
            {
                b.Navigation("Communications");

                b.Navigation("course");

                b.Navigation("lectuerstudent");

                b.Navigation("session");

                b.Navigation("tasks");
            });

            modelBuilder.Entity("kidsschoolproject.Models.parent", b =>
            {
                b.Navigation("student");
            });

            modelBuilder.Entity("kidsschoolproject.Models.student", b =>
            {
                b.Navigation("Communications");

                b.Navigation("lectuerstudent");

                b.Navigation("student_Cources");

                b.Navigation("tasks");
            });
#pragma warning restore 612, 618
        }
    }
    }
