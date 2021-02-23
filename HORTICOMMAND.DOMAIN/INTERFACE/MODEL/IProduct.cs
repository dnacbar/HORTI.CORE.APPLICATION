﻿using System;

namespace HORTICOMMAND.DOMAIN.INTERFACE.MODEL
{
    public interface IProduct
    {
        Guid IdProduct { get; set; }
        string DsProduct { get; set; }
        DateTime DtCreation { get; set; }
        DateTime DtAtualization { get; set; }
        decimal NmValue { get; set; }
        byte? NmPercentDiscount { get; set; }
        DateTime? DtDiscount { get; set; }
        byte? IdUnit { get; set; }
        bool? BoStock { get; set; }
        string DsDescription { get; set; }

        decimal ProductValueWithDiscount();
        bool ValidatePercentDiscount();
    }
}
