using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace db_lez06_ef.Models;

public partial class AccLez07OtmCartaContext : DbContext
{
    public AccLez07OtmCartaContext()
    {
    }

    public AccLez07OtmCartaContext(DbContextOptions<AccLez07OtmCartaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cartum> Carta { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= ACEDEMY2024-04\\SQLEXPRESS;Database=acc_lez07_otm_carta;User Id=academy;Password=academy!;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cartum>(entity =>
        {
            entity.HasKey(e => e.CartaId).HasName("PK__Carta__30780D4DC0F6F613");

            entity.HasIndex(e => e.Codice, "UQ__Carta__40F9C18B9F5E9803").IsUnique();

            entity.Property(e => e.CartaId).HasColumnName("cartaID");
            entity.Property(e => e.Codice)
                .HasMaxLength(10)
                .HasColumnName("codice");
            entity.Property(e => e.Negozio)
                .HasMaxLength(50)
                .HasColumnName("negozio");
            entity.Property(e => e.PersonaRif).HasColumnName("personaRIF");

            entity.HasOne(d => d.PersonaRifNavigation).WithMany(p => p.Carta)
                .HasForeignKey(d => d.PersonaRif)
                .HasConstraintName("FK__Carta__personaRI__49C3F6B7");
        });

        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.PersonaId).HasName("PK__Persona__54B758F555FBEE54");

            entity.ToTable("Persona");

            entity.HasIndex(e => e.Email, "UQ__Persona__AB6E61641D2EECF5").IsUnique();

            entity.Property(e => e.PersonaId).HasColumnName("personaID");
            entity.Property(e => e.Cognome)
                .HasMaxLength(250)
                .HasColumnName("cognome");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.Nome)
                .HasMaxLength(250)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
