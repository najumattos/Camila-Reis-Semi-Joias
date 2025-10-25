using Camila_Reis_Semi_Joias.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Camila_Reis_Semi_Joias.API.Data;
    public class AppDbContext : IdentityDbContext<Usuario>
    {        

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        SeedUsuarioPadrao(builder);
        SeedCategoriaPadrao(builder);
        SeedProdutoPadrao(builder);
    }

    private static void SeedUsuarioPadrao(ModelBuilder builder)
    {
        #region Populate Roles - Perfis de Usuário
        List<IdentityRole> roles =
        [
            new IdentityRole() {
               Id = "0b44ca04-f6b0-4a8f-a953-1f2330d30894",
               Name = "Administrador",
               NormalizedName = "ADMINISTRADOR"
            },
            new IdentityRole() {
               Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
               Name = "Usuário",
               NormalizedName = "USUÁRIO"
            },
        ];
        builder.Entity<IdentityRole>().HasData(roles);
        #endregion

        #region Populate Usuário
        List<Usuario> usuarios = [
            new Usuario(){
                Id = "ddf093a6-6cb5-4ff7-9a64-83da34aee005",
                Email = "gallojunior@gmail.com",
                NormalizedEmail = "GALLOJUNIOR@GMAIL.COM",
                UserName = "gallouunior@gmail.com",
                NormalizedUserName = "GALLOJUNIOR@GMAIL.COM",
                LockoutEnabled = true,
                EmailConfirmed = true,
                Nome = "José Antonio Gallo Junior",
                DataNasc = DateTime.Parse("05/08/1981"),
                Foto = "/img/usuarios/avatar.png"
            }
        ];
        foreach (var user in usuarios)
        {
            PasswordHasher<Usuario> pass = new();
            user.PasswordHash = pass.HashPassword(user, "123456");
        }
        builder.Entity<Usuario>().HasData(usuarios);
        #endregion

        #region Populate UserRole - Usuário com Perfil
        List<IdentityUserRole<string>> userRoles =
        [
            new IdentityUserRole<string>() {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            }
        ];
        builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        #endregion
    }

    private static void SeedCategoriaPadrao(ModelBuilder builder)
    {
        List<Categoria> categorias = new()
        {
            new(){IdCategoria = 1, Nome ="Colares"},
            new(){IdCategoria = 2, Nome ="Aneis"},
            new(){IdCategoria = 3, Nome ="Pulseiras"},
            new(){IdCategoria = 4, Nome ="Brincos"},
            new(){IdCategoria = 5, Nome ="Conjuntos"},
        };
        builder.Entity<Categoria>().HasData(categorias);
    }

    private static void SeedProdutoPadrao(ModelBuilder builder)
    {
        List<Produto> produtos = new()
        {
            new(){IdProduto = 1,
                Nome = "Anel Borboleta Ouro",
                Descricao = "",
                Quantidade = 5,
                ValorCusto = 50.00,
                ValorVenda = 75.00,
                Foto = "",
                Destaque = false,
                CategoriaId = 2
            },
            new(){IdProduto = 2,
                Nome = "Anel Coração Prata",
                Descricao = "",
                Quantidade = 5,
                ValorCusto = 65.00,
                ValorVenda = 90.00,
                Foto = "",
                Destaque = false,
                CategoriaId = 2
            },
            new(){IdProduto = 3,
                Nome = "Anel Duplo Coração Prata",
                Descricao = "",
                Quantidade = 5,
                ValorCusto = 90.00,
                ValorVenda = 115.00,
                Foto = "",
                Destaque = false,
                CategoriaId = 2
            }
        };
        builder.Entity<Produto>().HasData(produtos);
    }

        
    }
