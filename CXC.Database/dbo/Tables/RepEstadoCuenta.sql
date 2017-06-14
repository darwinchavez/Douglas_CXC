CREATE TABLE [dbo].[RepEstadoCuenta] (
    [CodigoCliente]    INT           NULL,
    [Nombres]          NVARCHAR (50) NULL,
    [Apellidos]        NVARCHAR (50) NULL,
    [FechaTransaccion] DATETIME2 (0) NULL,
    [Num_Factura]      NVARCHAR (25) NULL,
    [Num_Recibo]       NVARCHAR (25) NULL,
    [Credito]          MONEY         NULL,
    [Abono]            MONEY         NULL,
    [Saldo]            MONEY         NULL,
    CONSTRAINT [SSMA_CC$RepEstadoCuenta$Apellidos$disallow_zero_length] CHECK (len([Apellidos])>(0)),
    CONSTRAINT [SSMA_CC$RepEstadoCuenta$Nombres$disallow_zero_length] CHECK (len([Nombres])>(0)),
    CONSTRAINT [SSMA_CC$RepEstadoCuenta$Num_Factura$disallow_zero_length] CHECK (len([Num_Factura])>(0)),
    CONSTRAINT [SSMA_CC$RepEstadoCuenta$Num_Recibo$disallow_zero_length] CHECK (len([Num_Recibo])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[FechaTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'FechaTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Num_Factura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Num_Factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Num_Recibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Num_Recibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Credito]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Credito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Abono]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Abono';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepEstadoCuenta].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepEstadoCuenta', @level2type = N'COLUMN', @level2name = N'Saldo';

