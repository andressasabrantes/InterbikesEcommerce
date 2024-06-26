﻿// <auto-generated />
using System;
using InterbikesWeb.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Interbikes.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Interbikes.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DisplayOrder")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Bicicleta"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Acessorios"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Pecas"
                        });
                });

            modelBuilder.Entity("Interbikes.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "BICICLETA GTSM1 RIDE FEMININA É IDEAL PARA MULHERES QUE QUEREM COMEÇAR A PEDALAR, FAZER MUITOS PASSEIOS E UTILIZAR NO DIA-A-DIA. SÃO 2 TIPOS DE TAMANHOS DE QUADRO E 3 CORES PARA VOCÊ ESCOLHER, O PESO TOTAL DA BIKE É DE 15KG MONTADA. A BIKE É DIRETA DA FÁBRICA OFICIAL GTS M1 COM MAIS DE 28 ANOS NO MERCADO E GARANTIA EXCLUSIVA COM SUPORTE DIFERENCIADO. A BICICLETA SUPORTA UMA PESSOA DE ATÉ 100KGS.",
                            ImageUrl = "",
                            Name = "Bicleta Feminina Aro 29 GTS Freio a Disco Quadro 15",
                            Price = 989.10000000000002
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Quadro 29 A6061 KSW XLT 100 Alumínio. Abraçadeira Quadro c/ Blocagem 31.8 Alumínio. Suporte de Guidão 80mmx31.8x7mm Alumínio. Canote Selim 27.2x350 sem Carrinho. Guidão Mtb 680x31.8x30mm Alumínio.",
                            ImageUrl = "",
                            Name = "Bicicleta Aro 29 Ksw 21 Marchas Alumínio Cambio Shimano Freio a Disco",
                            Price = 969.89999999999998
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Terra, lama, descidas, subidas, galhos, pedras, saltos e curvas apertadas... são obstáculos que você enfrentará em seus passeios e trilhas, seja você um ciclista por hobby ou profissional. A Bicicleta modelo Legend, da marca South Bike e tipo Mountain Bike foi feita pensando em você aventureiro! Ela é aro 29, conta com um freio a disco garantindo conforto e segurança e 21 marchas para maior aproveitamento de suas pedaladas. Seu câmbio é Shimano (TZ dianteiro e traseiro) e seu diferencial fica por conta de sua suspensão dianteira com 60 mm de curso.",
                            ImageUrl = "",
                            Name = "Bicicleta South Legend Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas",
                            Price = 1.399
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Terra, lama, descidas, subidas, galhos, pedras, saltos e curvas apertadas... são obstáculos que você enfrentará em seus passeios e trilhas, seja você um ciclista por hobby ou profissional. A Bicicleta modelo Legend, da marca South Bike e tipo Mountain Bike foi feita pensando em você aventureiro! Ela é aro 29, conta com um freio a disco garantindo conforto e segurança e 21 marchas para maior aproveitamento de suas pedaladas. Seu câmbio é Shimano (TZ dianteiro e traseiro) e seu diferencial fica por conta de sua suspensão dianteira com 60 mm de curso.",
                            ImageUrl = "",
                            Name = "Bicicleta South Legend Preto com Verde Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas",
                            Price = 1.399
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Bicicleta South Legend Preto com Verde Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas",
                            ImageUrl = "",
                            Name = "Bicicleta South Legend Preto com Rosa com Verde Aro 29 Quadro 15 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas",
                            Price = 1.399
                        });
                });

            modelBuilder.Entity("Interbikes.Models.Product", b =>
                {
                    b.HasOne("Interbikes.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
