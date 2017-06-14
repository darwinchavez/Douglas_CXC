CREATE TABLE [dbo].[RegistrosxCliente] (
    [Numero]           INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente]    INT           NULL,
    [FechaTransaccion] DATETIME2 (0) NULL,
    [NumDocumento]     NVARCHAR (15) NULL,
    [Monto]            FLOAT (53)    NULL,
    [TipoTransaccion]  NVARCHAR (15) NULL,
    CONSTRAINT [FK_RegistrosxCliente_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente].[FechaTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente', @level2type = N'COLUMN', @level2name = N'FechaTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente].[NumDocumento]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente', @level2type = N'COLUMN', @level2name = N'NumDocumento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosxCliente].[TipoTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosxCliente', @level2type = N'COLUMN', @level2name = N'TipoTransaccion';

