﻿using System;
using System.ComponentModel.DataAnnotations;

public class Reporte
{


    public string Id { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo fecha es requerido")]
    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Descripcion es requerido")]
    [MinLength(10, ErrorMessage = "la descripcion debe tener al menos 10 caracteres")]

    public string Descripcion { get; set; } = "";
    public double CostoEstimado { get; set; } = 0;
    public int Muertos { get; set; } = 0;
    public int Heridos { get; set; } = 0;
    public int VehiculosInvolucrados { get; set; } = 0;
}