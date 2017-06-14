CREATE TABLE [dbo].[EstadoCuenta] (
    [CodigoCliente]    INT           NULL,
    [FechaTransaccion] DATETIME2 (0) NULL,
    [Num_Factura]      NVARCHAR (25) NULL,
    [Credito]          MONEY         NULL,
    [Num_Recibo]       NVARCHAR (25) NULL,
    [Abono]            MONEY         NULL,
    [Tipo_Transaccion] NVARCHAR (20) NULL,
    [Saldo]            MONEY         NULL,
    CONSTRAINT [FK_EstadoCuenta_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
CREATE NONCLUSTERED INDEX [EstadoCuenta$EstadoCuentaCodigoCliente]
    ON [dbo].[EstadoCuenta]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[EstadoCuentaCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'INDEX', @level2name = N'EstadoCuenta$EstadoCuentaCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[FechaTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'FechaTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[Num_Factura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'Num_Factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[Credito]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'Credito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[Num_Recibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'Num_Recibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[Abono]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'Abono';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[Tipo_Transaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'Tipo_Transaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstadoCuenta].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstadoCuenta', @level2type = N'COLUMN', @level2name = N'Saldo';

