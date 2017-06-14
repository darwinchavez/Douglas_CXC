CREATE TABLE [dbo].[SaldoAnterior] (
    [CodigoCliente]   INT           NULL,
    [TipoTransaccion] NVARCHAR (15) NULL,
    [Monto]           FLOAT (53)    DEFAULT ((0)) NULL,
    CONSTRAINT [FK_SaldoAnterior_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnterior]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnterior';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnterior].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnterior', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnterior].[TipoTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnterior', @level2type = N'COLUMN', @level2name = N'TipoTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnterior].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnterior', @level2type = N'COLUMN', @level2name = N'Monto';

