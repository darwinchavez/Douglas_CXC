CREATE TABLE [dbo].[RdeFacturas] (
    [CodigoCliente]    INT           NULL,
    [Nombres]          NVARCHAR (60) NULL,
    [Apellidos]        NVARCHAR (60) NULL,
    [FechaTransaccion] DATETIME2 (0) NULL,
    [NumDocumento]     NVARCHAR (25) NULL,
    [Monto]            FLOAT (53)    NULL,
    [SSMA_TimeStamp]   ROWVERSION    NOT NULL
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas].[FechaTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas', @level2type = N'COLUMN', @level2name = N'FechaTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas].[NumDocumento]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas', @level2type = N'COLUMN', @level2name = N'NumDocumento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RdeFacturas].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RdeFacturas', @level2type = N'COLUMN', @level2name = N'Monto';

