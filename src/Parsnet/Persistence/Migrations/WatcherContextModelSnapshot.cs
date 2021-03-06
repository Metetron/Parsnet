﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parsnet.Persistence;

namespace Parsnet.Persistence.Migrations
{
    [DbContext(typeof(WatcherContext))]
    partial class WatcherContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Parsnet.FileWatchers.CreationTimeWatcher.Data.CreationTimeWatcherData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("LastCreationTimeUtc")
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0L);

                    b.Property<string>("ParserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CreationTimeWatchers");
                });

            modelBuilder.Entity("Parsnet.FileWatchers.WriteTimeWatcher.Data.WriteTimeWatcherData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("LastWriteTimeUtc")
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0L);

                    b.Property<string>("ParserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("WriteTimeWatchers");
                });
#pragma warning restore 612, 618
        }
    }
}
