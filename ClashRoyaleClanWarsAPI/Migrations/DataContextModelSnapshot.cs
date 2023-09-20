﻿// <auto-generated />
using System;
using ClashRoyaleClanWarsAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClashRoyaleClanWarsAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.BattleModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AmountTrophies")
                        .HasColumnType("int");

                    b.Property<int>("DurationInSeconds")
                        .HasColumnType("int");

                    b.Property<int>("WinnerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WinnerId");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.CardModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AreaDamage")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Elixir")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InitialLevel")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quality")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cards");

                    b.HasDiscriminator<int>("Type").HasValue(0);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.ChallengeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountReward")
                        .HasColumnType("int");

                    b.Property<int>("Cost")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DurationInHours")
                        .HasColumnType("int");

                    b.Property<int>("LossLimit")
                        .HasColumnType("int");

                    b.Property<int>("MinTrophies")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Challenges");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.ClanModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AmountMembers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MinTrophies")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrophiesInWar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<bool>("TypeOpen")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.ClanWarsModel", b =>
                {
                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<int>("WarId")
                        .HasColumnType("int");

                    b.Property<int>("Prize")
                        .HasColumnType("int");

                    b.HasKey("ClanId", "WarId");

                    b.HasIndex("WarId");

                    b.ToTable("ClanWars");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.CollectModel", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "CardId");

                    b.HasIndex("CardId");

                    b.ToTable("Collection");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.DonationModel", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<int>("CardId")
                        .HasColumnType("int");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "ClanId", "CardId");

                    b.HasIndex("CardId");

                    b.HasIndex("ClanId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerChallengesModel", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ChallengeId")
                        .HasColumnType("int");

                    b.Property<int>("PrizeAmount")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "ChallengeId");

                    b.HasIndex("ChallengeId");

                    b.ToTable("PlayerChallenges");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerClansModel", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("ClanId")
                        .HasColumnType("int");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "ClanId");

                    b.HasIndex("ClanId");

                    b.ToTable("PlayerClans");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CardAmount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("FavoriteCardId")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(1);

                    b.Property<int>("MaxElo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Victories")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("FavoriteCardId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.WarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Wars");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.SpellModel", b =>
                {
                    b.HasBaseType("ClashRoyaleClanWarsAPI.Models.CardModel");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Radius")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("int")
                        .HasColumnName("Radius");

                    b.Property<int>("TowerDamage")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.StructureModel", b =>
                {
                    b.HasBaseType("ClashRoyaleClanWarsAPI.Models.CardModel");

                    b.Property<float>("AttackSpeed")
                        .HasColumnType("real");

                    b.Property<int>("HitPoints")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("int")
                        .HasColumnName("HitPoints");

                    b.Property<int>("Radius")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("int")
                        .HasColumnName("Radius");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.TroopModel", b =>
                {
                    b.HasBaseType("ClashRoyaleClanWarsAPI.Models.CardModel");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("HitPoints")
                        .ValueGeneratedOnUpdateSometimes()
                        .HasColumnType("int")
                        .HasColumnName("HitPoints");

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.BattleModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.PlayerModel", "Winner")
                        .WithMany()
                        .HasForeignKey("WinnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Winner");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.ClanWarsModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.ClanModel", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClashRoyaleClanWarsAPI.Models.WarModel", "War")
                        .WithMany()
                        .HasForeignKey("WarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clan");

                    b.Navigation("War");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.CollectModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.CardModel", "Card")
                        .WithMany("CardOwners")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClashRoyaleClanWarsAPI.Models.PlayerModel", "Player")
                        .WithMany("Cards")
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.DonationModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.CardModel", "Card")
                        .WithMany()
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClashRoyaleClanWarsAPI.Models.ClanModel", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClashRoyaleClanWarsAPI.Models.PlayerModel", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Card");

                    b.Navigation("Clan");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerChallengesModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.ChallengeModel", "Challenge")
                        .WithMany()
                        .HasForeignKey("ChallengeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClashRoyaleClanWarsAPI.Models.PlayerModel", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Challenge");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerClansModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.ClanModel", "Clan")
                        .WithMany()
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClashRoyaleClanWarsAPI.Models.PlayerModel", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Clan");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerModel", b =>
                {
                    b.HasOne("ClashRoyaleClanWarsAPI.Models.CardModel", "FavoriteCard")
                        .WithMany()
                        .HasForeignKey("FavoriteCardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FavoriteCard");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.CardModel", b =>
                {
                    b.Navigation("CardOwners");
                });

            modelBuilder.Entity("ClashRoyaleClanWarsAPI.Models.PlayerModel", b =>
                {
                    b.Navigation("Cards");
                });
#pragma warning restore 612, 618
        }
    }
}
