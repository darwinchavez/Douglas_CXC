CREATE TABLE [dbo].[SalAntCreditos] (
    [Numero]         INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente]  INT           NULL,
    [FechaCredito]   DATETIME2 (0) NULL,
    [Num_Factura]    NVARCHAR (15) NULL,
    [Monto]          FLOAT (53)    NULL,
    [Tipo]           NVARCHAR (15) NULL,
    [SSMA_TimeStamp] ROWVERSION    NOT NULL,
    CONSTRAINT [SSMA_CC$SalAntCreditos$Num_Factura$disallow_zero_length] CHECK (len([Num_Factura])>(0)),
    CONSTRAINT [SSMA_CC$SalAntCreditos$Tipo$disallow_zero_length] CHECK (len([Tipo])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos].[FechaCredito]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos', @level2type = N'COLUMN', @level2name = N'FechaCredito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos].[Num_Factura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos', @level2type = N'COLUMN', @level2name = N'Num_Factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntCreditos].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntCreditos', @level2type = N'COLUMN', @level2name = N'Tipo';

