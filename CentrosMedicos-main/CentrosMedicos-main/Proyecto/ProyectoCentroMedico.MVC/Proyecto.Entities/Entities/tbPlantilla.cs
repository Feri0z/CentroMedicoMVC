﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Proyecto.Entities.Entities
{
    public partial class tbPlantilla
    {
        public tbPlantilla()
        {
            tbEnfermo = new HashSet<tbEnfermo>();
        }

        public int? hospi_Id { get; set; }
        public int? sala_Id { get; set; }
        public int planti_EmpleadoId { get; set; }
        public string planti_Apellido { get; set; }
        public string planti_Funcion { get; set; }
        public string planti_Turno { get; set; }
        public int planti_Salario { get; set; }

        public virtual tbHospiltales hospi { get; set; }
        public virtual tbSala sala { get; set; }
        public virtual ICollection<tbEnfermo> tbEnfermo { get; set; }
    }
}