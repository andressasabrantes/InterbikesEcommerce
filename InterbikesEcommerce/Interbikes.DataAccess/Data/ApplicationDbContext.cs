using Interbikes.Models;
using Microsoft.EntityFrameworkCore;

namespace InterbikesWeb.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Bicicleta", DisplayOrder = 1},
                new Category { Id = 2, Name = "Acessorios", DisplayOrder = 2},
                new Category { Id = 3, Name = "Pecas", DisplayOrder = 3}
                );
            modelBuilder.Entity<Product>().HasData(
                new Product 
                { 
                    Id = 1,
                    Name = "Bicleta Feminina Aro 29 GTS Freio a Disco Quadro 15", 
                    Price = 989.10, 
                    Description = "BICICLETA GTSM1 RIDE FEMININA É IDEAL PARA MULHERES QUE QUEREM COMEÇAR A PEDALAR, FAZER MUITOS PASSEIOS E UTILIZAR NO DIA-A-DIA. SÃO 2 TIPOS DE TAMANHOS DE QUADRO E 3 CORES PARA VOCÊ ESCOLHER, O PESO TOTAL DA BIKE É DE 15KG MONTADA. A BIKE É DIRETA DA FÁBRICA OFICIAL GTS M1 COM MAIS DE 28 ANOS NO MERCADO E GARANTIA EXCLUSIVA COM SUPORTE DIFERENCIADO. A BICICLETA SUPORTA UMA PESSOA DE ATÉ 100KGS.",
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 2, 
                    Name = "Bicicleta Aro 29 Ksw 21 Marchas Alumínio Cambio Shimano Freio a Disco", 
                    Price = 969.90, 
                    Description = "Quadro 29 A6061 KSW XLT 100 Alumínio. Abraçadeira Quadro c/ Blocagem 31.8 Alumínio. Suporte de Guidão 80mmx31.8x7mm Alumínio. Canote Selim 27.2x350 sem Carrinho. Guidão Mtb 680x31.8x30mm Alumínio.",
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 3, 
                    Name = "Bicicleta South Legend Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", 
                    Price = 1.399, 
                    Description = "Terra, lama, descidas, subidas, galhos, pedras, saltos e curvas apertadas... são obstáculos que você enfrentará em seus passeios e trilhas, seja você um ciclista por hobby ou profissional. A Bicicleta modelo Legend, da marca South Bike e tipo Mountain Bike foi feita pensando em você aventureiro! Ela é aro 29, conta com um freio a disco garantindo conforto e segurança e 21 marchas para maior aproveitamento de suas pedaladas. Seu câmbio é Shimano (TZ dianteiro e traseiro) e seu diferencial fica por conta de sua suspensão dianteira com 60 mm de curso.",
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 4, 
                    Name = "Bicicleta South Legend Preto com Verde Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", 
                    Price = 1.399, 
                    Description = "Terra, lama, descidas, subidas, galhos, pedras, saltos e curvas apertadas... são obstáculos que você enfrentará em seus passeios e trilhas, seja você um ciclista por hobby ou profissional. A Bicicleta modelo Legend, da marca South Bike e tipo Mountain Bike foi feita pensando em você aventureiro! Ela é aro 29, conta com um freio a disco garantindo conforto e segurança e 21 marchas para maior aproveitamento de suas pedaladas. Seu câmbio é Shimano (TZ dianteiro e traseiro) e seu diferencial fica por conta de sua suspensão dianteira com 60 mm de curso.",
                    CategoryId = 1,
                    ImageUrl = ""
                },
                new Product 
                { 
                    Id = 5, 
                    Name = "Bicicleta South Legend Preto com Rosa com Verde Aro 29 Quadro 15 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas", 
                    Price = 1.399, 
                    Description = "Bicicleta South Legend Preto com Verde Aro 29 Shimano Alumínio - Mountain Bike Freio a Disco 21 Marchas",
                    CategoryId = 1,
                    ImageUrl = ""
                }
                );
        }
    }
}
