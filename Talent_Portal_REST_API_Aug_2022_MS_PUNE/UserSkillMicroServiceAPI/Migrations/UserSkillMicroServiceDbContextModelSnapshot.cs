﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UserSkillMicroserviceAPI.Data;

#nullable disable

namespace UserSkillMicroserviceAPI.Migrations
{
    [DbContext(typeof(UserSkillMicroServiceDbContext))]
    partial class UserSkillMicroServiceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UserSkillMicroServiceAPI.Models.Domain.UserSkill", b =>
                {
                    b.Property<int>("UserSkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserSkillId"), 1L, 1);

                    b.Property<int?>("SkillId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserSkillId");

                    b.ToTable("UserSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
