CREATE TABLE [dbo].[RepTarjetas] (
    [CodigoCliente]  INT           NULL,
    [Nombres]        NVARCHAR (50) NULL,
    [Apellidos]      NVARCHAR (50) NULL,
    [Numero]         INT           NULL,
    [FechaIngreso]   DATETIME2 (0) NULL,
    [Num_Lote]       NVARCHAR (15) NULL,
    [Monto]          FLOAT (53)    NULL,
    [Tipo]           NVARCHAR (15) NULL,
    [SSMA_TimeStamp] ROWVERSION    NOT NULL
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[FechaIngreso]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'FechaIngreso';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[Num_Lote]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'Num_Lote';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepTarjetas].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepTarjetas', @level2type = N'COLUMN', @level2name = N'Tipo';

