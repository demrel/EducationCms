﻿// <auto-generated />
using System;
using EducationCms.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EducationCms.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20210813195625_PageTableChanges")]
    partial class PageTableChanges
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EducationCms.Data.Model.AppImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.Banner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ImageId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("TitleFirst")
                        .HasColumnType("text");

                    b.Property<string>("TitleSecond")
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Banners");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.Consumer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsStared")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Position")
                        .HasColumnType("text");

                    b.Property<string>("Review")
                        .HasColumnType("text");

                    b.Property<int?>("SeminarId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("SeminarId");

                    b.ToTable("Consumers");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.MissionVision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ImageId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("MissionVisions");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.Page", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Description2")
                        .HasColumnType("text");

                    b.Property<string>("Description3")
                        .HasColumnType("text");

                    b.Property<string>("Description4")
                        .HasColumnType("text");

                    b.Property<string>("Icon")
                        .HasColumnType("text");

                    b.Property<bool>("IsStared")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Title2")
                        .HasColumnType("text");

                    b.Property<string>("Title3")
                        .HasColumnType("text");

                    b.Property<string>("Title4")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.QuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answer")
                        .HasColumnType("text");

                    b.Property<string>("Question")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.TizerVideoPlace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ContactText")
                        .HasColumnType("text");

                    b.Property<string>("DescriptionFirst")
                        .HasColumnType("text");

                    b.Property<string>("DescriptionSecond")
                        .HasColumnType("text");

                    b.Property<int>("ImageRectId")
                        .HasColumnType("integer");

                    b.Property<int>("ImageSquareId")
                        .HasColumnType("integer");

                    b.Property<int>("Percent1")
                        .HasColumnType("integer");

                    b.Property<int>("Percent2")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<string>("Value1")
                        .HasColumnType("text");

                    b.Property<string>("Value2")
                        .HasColumnType("text");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ImageRectId");

                    b.HasIndex("ImageSquareId");

                    b.ToTable("TizerVideoPlaces");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.BasePost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("BannerImageId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("Time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BannerImageId");

                    b.ToTable("BasePost");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EducationCms.Data.Model.SiteSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("BuisnesStartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ContactTitle")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Facebook")
                        .HasColumnType("text");

                    b.Property<string>("Instagram")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Twitter")
                        .HasColumnType("text");

                    b.Property<string>("Youtube")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("SiteSettings");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<int?>("ImageId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppUserRole", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId1")
                        .HasColumnType("text");

                    b.Property<string>("UserId1")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Blog", b =>
                {
                    b.HasBaseType("EducationCms.Data.Model.Posts.BasePost");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.HasIndex("CategoryId");

                    b.ToTable("Blog");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Consulting", b =>
                {
                    b.HasBaseType("EducationCms.Data.Model.Posts.BasePost");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.ToTable("Consulting");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.English", b =>
                {
                    b.HasBaseType("EducationCms.Data.Model.Posts.BasePost");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Seminar", b =>
                {
                    b.HasBaseType("EducationCms.Data.Model.Posts.BasePost");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.ToTable("Seminar");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Summary", b =>
                {
                    b.HasBaseType("EducationCms.Data.Model.Posts.BasePost");

                    b.Property<string>("Url")
                        .HasColumnType("text");

                    b.ToTable("FileShare");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Video", b =>
                {
                    b.HasBaseType("EducationCms.Data.Model.Posts.BasePost");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("text");

                    b.ToTable("Video");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.Banner", b =>
                {
                    b.HasOne("EducationCms.Data.Model.AppImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.Consumer", b =>
                {
                    b.HasOne("EducationCms.Data.Model.AppImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.HasOne("EducationCms.Data.Model.Posts.Seminar", "Seminar")
                        .WithMany()
                        .HasForeignKey("SeminarId");

                    b.Navigation("Image");

                    b.Navigation("Seminar");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.MissionVision", b =>
                {
                    b.HasOne("EducationCms.Data.Model.AppImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Image");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Pages.TizerVideoPlace", b =>
                {
                    b.HasOne("EducationCms.Data.Model.AppImage", "ImageRect")
                        .WithMany()
                        .HasForeignKey("ImageRectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationCms.Data.Model.AppImage", "ImageSquare")
                        .WithMany()
                        .HasForeignKey("ImageSquareId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ImageRect");

                    b.Navigation("ImageSquare");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.BasePost", b =>
                {
                    b.HasOne("EducationCms.Data.Model.AppImage", "BannerImage")
                        .WithMany()
                        .HasForeignKey("BannerImageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BannerImage");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppUser", b =>
                {
                    b.HasOne("EducationCms.Data.Model.AppImage", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppUserRole", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Users.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationCms.Data.Model.Users.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId1");

                    b.HasOne("EducationCms.Data.Model.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationCms.Data.Model.Users.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Users.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Users.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Blog", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Posts.Category", "Cateogry")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EducationCms.Data.Model.Posts.BasePost", null)
                        .WithOne()
                        .HasForeignKey("EducationCms.Data.Model.Posts.Blog", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cateogry");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Consulting", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Posts.BasePost", null)
                        .WithOne()
                        .HasForeignKey("EducationCms.Data.Model.Posts.Consulting", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.English", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Posts.BasePost", null)
                        .WithOne()
                        .HasForeignKey("EducationCms.Data.Model.Posts.English", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Seminar", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Posts.BasePost", null)
                        .WithOne()
                        .HasForeignKey("EducationCms.Data.Model.Posts.Seminar", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Summary", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Posts.BasePost", null)
                        .WithOne()
                        .HasForeignKey("EducationCms.Data.Model.Posts.Summary", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Video", b =>
                {
                    b.HasOne("EducationCms.Data.Model.Posts.BasePost", null)
                        .WithOne()
                        .HasForeignKey("EducationCms.Data.Model.Posts.Video", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EducationCms.Data.Model.Posts.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("EducationCms.Data.Model.Users.AppUser", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
