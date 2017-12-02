﻿// <auto-generated />
using GMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace GMS.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171202194324_AddRelationTables")]
    partial class AddRelationTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GMS.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("GMS.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Description");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("GMS.Models.DetailSubType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Description");

                    b.Property<int?>("DetailTypeId");

                    b.Property<bool>("IsDefault");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("DetailTypeId");

                    b.ToTable("DetailSubType");
                });

            modelBuilder.Entity("GMS.Models.DetailType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Description");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.ToTable("DetailType");
                });

            modelBuilder.Entity("GMS.Models.Entity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("EntityTypeId");

                    b.Property<bool>("IsSubscribedToNewsLetter");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("EntityTypeId");

                    b.ToTable("Entity");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Entity");
                });

            modelBuilder.Entity("GMS.Models.EntityAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1");

                    b.Property<string>("AddressLine2");

                    b.Property<int?>("AddressTypeId");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<int?>("EntityId");

                    b.Property<int?>("PersonId");

                    b.Property<string>("PostalCode");

                    b.Property<string>("State");

                    b.Property<string>("Suburb");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("AddressTypeId");

                    b.HasIndex("EntityId");

                    b.HasIndex("PersonId");

                    b.ToTable("EntityAddresses");
                });

            modelBuilder.Entity("GMS.Models.EntityEmailAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AddressTypeId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("EmailAddress");

                    b.Property<int?>("EntityId");

                    b.Property<int?>("PersonId");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("AddressTypeId");

                    b.HasIndex("EntityId");

                    b.HasIndex("PersonId");

                    b.ToTable("EntityEmailAddresses");
                });

            modelBuilder.Entity("GMS.Models.EntityName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int?>("EntityId");

                    b.Property<int?>("NameTypeId");

                    b.Property<string>("ResolvedName");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("EntityId");

                    b.HasIndex("NameTypeId");

                    b.ToTable("EntityName");

                    b.HasDiscriminator<string>("Discriminator").HasValue("EntityName");
                });

            modelBuilder.Entity("GMS.Models.EntityPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<int?>("DetailTypeId");

                    b.Property<int?>("EntityId");

                    b.Property<int?>("PersonId");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.HasIndex("DetailTypeId");

                    b.HasIndex("EntityId");

                    b.HasIndex("PersonId");

                    b.ToTable("EntityPhones");
                });

            modelBuilder.Entity("GMS.Models.EntityType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Description");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.ToTable("EntityTypes");
                });

            modelBuilder.Entity("GMS.Models.RelationshipType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Description");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.ToTable("RelationshipTypes");
                });

            modelBuilder.Entity("GMS.Models.Title", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateLastUpdated");

                    b.Property<string>("Description");

                    b.Property<int>("UserCreated");

                    b.Property<int>("UserLastUpdated");

                    b.HasKey("Id");

                    b.ToTable("Title");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GMS.Models.Organisation", b =>
                {
                    b.HasBaseType("GMS.Models.Entity");


                    b.ToTable("Organisation");

                    b.HasDiscriminator().HasValue("Organisation");
                });

            modelBuilder.Entity("GMS.Models.Person", b =>
                {
                    b.HasBaseType("GMS.Models.Entity");

                    b.Property<int?>("CountryOfBirthId");

                    b.Property<int?>("CountryOfCitzenshipId");

                    b.Property<DateTime>("DateOfBirth");

                    b.HasIndex("CountryOfBirthId");

                    b.HasIndex("CountryOfCitzenshipId");

                    b.ToTable("Person");

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("GMS.Models.OrganisationName", b =>
                {
                    b.HasBaseType("GMS.Models.EntityName");

                    b.Property<string>("Name");

                    b.ToTable("OrganisationName");

                    b.HasDiscriminator().HasValue("OrganisationName");
                });

            modelBuilder.Entity("GMS.Models.PersonName", b =>
                {
                    b.HasBaseType("GMS.Models.EntityName");

                    b.Property<string>("FirstName");

                    b.Property<string>("MiddleName");

                    b.Property<int?>("PersonId");

                    b.Property<string>("Surname");

                    b.Property<int?>("TitleId");

                    b.HasIndex("PersonId");

                    b.HasIndex("TitleId");

                    b.ToTable("PersonName");

                    b.HasDiscriminator().HasValue("PersonName");
                });

            modelBuilder.Entity("GMS.Models.DetailSubType", b =>
                {
                    b.HasOne("GMS.Models.DetailType", "DetailType")
                        .WithMany()
                        .HasForeignKey("DetailTypeId");
                });

            modelBuilder.Entity("GMS.Models.Entity", b =>
                {
                    b.HasOne("GMS.Models.EntityType", "EntityType")
                        .WithMany()
                        .HasForeignKey("EntityTypeId");
                });

            modelBuilder.Entity("GMS.Models.EntityAddress", b =>
                {
                    b.HasOne("GMS.Models.DetailSubType", "AddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeId");

                    b.HasOne("GMS.Models.Entity", "Entity")
                        .WithMany("Addressess")
                        .HasForeignKey("EntityId");

                    b.HasOne("GMS.Models.Person")
                        .WithMany("Adressess")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("GMS.Models.EntityEmailAddress", b =>
                {
                    b.HasOne("GMS.Models.DetailSubType", "AddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeId");

                    b.HasOne("GMS.Models.Entity", "Entity")
                        .WithMany("EmailAddressess")
                        .HasForeignKey("EntityId");

                    b.HasOne("GMS.Models.Person")
                        .WithMany("EmailAdresses")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("GMS.Models.EntityName", b =>
                {
                    b.HasOne("GMS.Models.Entity", "Entity")
                        .WithMany("Names")
                        .HasForeignKey("EntityId");

                    b.HasOne("GMS.Models.DetailSubType", "NameType")
                        .WithMany()
                        .HasForeignKey("NameTypeId");
                });

            modelBuilder.Entity("GMS.Models.EntityPhone", b =>
                {
                    b.HasOne("GMS.Models.DetailType", "DetailType")
                        .WithMany()
                        .HasForeignKey("DetailTypeId");

                    b.HasOne("GMS.Models.Entity", "Entity")
                        .WithMany("Phones")
                        .HasForeignKey("EntityId");

                    b.HasOne("GMS.Models.Person")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GMS.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GMS.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GMS.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GMS.Data.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GMS.Models.Person", b =>
                {
                    b.HasOne("GMS.Models.Country", "CountryOfBirth")
                        .WithMany()
                        .HasForeignKey("CountryOfBirthId");

                    b.HasOne("GMS.Models.Country", "CountryOfCitzenship")
                        .WithMany()
                        .HasForeignKey("CountryOfCitzenshipId");
                });

            modelBuilder.Entity("GMS.Models.PersonName", b =>
                {
                    b.HasOne("GMS.Models.Person")
                        .WithMany("PersonNames")
                        .HasForeignKey("PersonId");

                    b.HasOne("GMS.Models.Title", "Title")
                        .WithMany()
                        .HasForeignKey("TitleId");
                });
#pragma warning restore 612, 618
        }
    }
}
