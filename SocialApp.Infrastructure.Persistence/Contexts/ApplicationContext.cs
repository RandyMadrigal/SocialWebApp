using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SocialApp.Core.Application.Helpers;
using SocialApp.Core.Application.ViewModels.User;
using SocialApp.Core.Domain.Common;
using SocialApp.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SocialApp.Infrastructure.Persistence.Contexts
{
    public class ApplicationContext : DbContext
    {
       private readonly IHttpContextAccessor _httpContextAccessor;
       private readonly UserVm _userVm;

        public ApplicationContext(DbContextOptions<ApplicationContext> options,
            IHttpContextAccessor httpContextAccessor) : base(options)
        {
          _httpContextAccessor = httpContextAccessor;
          _userVm = _httpContextAccessor.HttpContext.Session.Get<UserVm>("user");
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableBaseEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                      entry.Entity.CreateBy = _userVm.UserName;
                      entry.Entity.Created = DateTime.Now;

                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        //Indicando al Context las Entities que se van a utilizar.
        public DbSet<User> User { get; set; }
        public DbSet<Publication> Publication { get; set; }
        public DbSet<Friend> Friend { get; set; }
        public DbSet<Commentary> commentaries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API -Configuracion de la base de datos

            #region tablas

            modelBuilder.Entity<User>()
                .ToTable("Usuarios");

            modelBuilder.Entity<Publication>()
                .ToTable("Publicaciones");

            modelBuilder.Entity<Friend>()
                .ToTable("Amigos");

            modelBuilder.Entity<Commentary>()
                 .ToTable("Comentarios");

            #endregion

            #region Unique Index

            modelBuilder.Entity<User>()
                .HasIndex(user => user.UserName)
                .IsUnique();

            #endregion


            #region Primary keys
            modelBuilder.Entity<User>()
                .HasKey(user => user.Id);

            modelBuilder.Entity<Publication>()
                .HasKey(publication => publication.Id);

            modelBuilder.Entity<Friend>()
                .HasKey(friend => friend.Id);

            modelBuilder.Entity<Commentary>()
                .HasKey(comentario => comentario.Id);


            #endregion

            #region Relationships

            modelBuilder.Entity<User>()
                .HasMany<Publication>(user => user.Publication) //Navigation Property de Publicacion en User
                .WithOne(publication => publication.User) //Navigation Property de User en publicacion
                .HasForeignKey(publication => publication.UserId) //ForeignKey
                .OnDelete(DeleteBehavior.Cascade); //Borrado

            
            modelBuilder.Entity<User>()
               .HasMany<Friend>(user => user.Friend) //Navigation Property de Amigo en User
               .WithOne(friend => friend.User) //Navigation Property de User en Amigo
               .HasForeignKey(friend => friend.FriendId) //ForeignKey
               .OnDelete(DeleteBehavior.Cascade); //Borrado


            modelBuilder.Entity<Publication>()
               .HasMany<Commentary>(publication => publication.commentaries) //Navigation Property de publication / Comment
               .WithOne(comment => comment._publication) //Navigation Property de Comment / publication
               .HasForeignKey(comment => comment.PublicationId) //ForeignKey
               .OnDelete(DeleteBehavior.Cascade); //Borrado

            #endregion

            #region Constraints User

            modelBuilder.Entity<User>().Property(user => user.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<User>().Property(user => user.Apellido)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder.Entity<User>().Property(user => user.Email)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<User>().Property(user => user.Phone)
               .IsRequired()
               .HasMaxLength(20);

            modelBuilder.Entity<User>().Property(user => user.UserName)
               .IsRequired()
               .HasMaxLength(30);

            modelBuilder.Entity<User>().Property(user => user.Password)
               .IsRequired();

            #endregion

        }


    }
}
