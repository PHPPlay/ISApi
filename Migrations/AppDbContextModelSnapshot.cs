﻿// <auto-generated />
using ISApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ISApi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ISApi.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("TicketId");

                    b.HasKey("Id");

                    b.HasIndex("TicketId");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("ISApi.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DateCreated");

                    b.Property<string>("Description");

                    b.Property<bool>("IsCallBack");

                    b.Property<int?>("MonthCreated");

                    b.Property<int?>("SitNumber");

                    b.Property<int>("StatusId");

                    b.Property<string>("Title");

                    b.Property<int?>("YearCreated");

                    b.HasKey("Id");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("ISApi.Models.Status", b =>
                {
                    b.HasOne("ISApi.Models.Ticket")
                        .WithMany("Statuses")
                        .HasForeignKey("TicketId");
                });
#pragma warning restore 612, 618
        }
    }
}
