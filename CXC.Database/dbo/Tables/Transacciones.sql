CREATE TABLE [dbo].[Transacciones] (
    [Numero]           INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente]    INT           NOT NULL,
    [FechaTransaccion] DATETIME2 (0) NULL,
    [NumDocumento]     NVARCHAR (15) NOT NULL,
    [Monto]            FLOAT (53)    NULL,
    [TipoTransaccion]  NVARCHAR (15) NULL,
    CONSTRAINT [Transacciones$PrimaryKey] PRIMARY KEY CLUSTERED ([CodigoCliente] ASC, [NumDocumento] ASC),
    CONSTRAINT [FK_Transacciones_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[FechaTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'COLUMN', @level2name = N'FechaTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[NumDocumento]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'COLUMN', @level2name = N'NumDocumento';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[TipoTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'COLUMN', @level2name = N'TipoTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Transacciones].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Transacciones', @level2type = N'CONSTRAINT', @level2name = N'Transacciones$PrimaryKey';

