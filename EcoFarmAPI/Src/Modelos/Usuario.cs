﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using static EcoFarmAPI.Src.Utilidades.Enum;

namespace EcoFarmAPI.Src.Modelos
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por representar tb_usuarios no banco.</para>
    /// <para>Criado por: Samara</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 09/08/2022</para>
    /// </summary>

    [Table("tb_usuarios")]
    public class Usuario
    {
        #region Atributos

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        [Required]
        public TipoUsuario Tipo { get; set; }

        [JsonIgnore, InverseProperty("CLIENTE")]
        public List<Carrinho> Compras { get; set; }

        [JsonIgnore, InverseProperty("Fornecedor")]
        public List<Estoque> ProdutosFornecidos { get; set; }

        #endregion
    }
    /// <summary>
    /// <para>Resumo: Responsavel por representar login do Usuario.</para>
    /// <para>Criado por: Jonathan</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 14/09/2022</para>
    /// </summary>
    public class LoginUsuario
    {
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
