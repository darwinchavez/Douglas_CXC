CREATE TABLE [dbo].[Saldos] (
    [CodigoCliente] INT           NULL,
    [Nombres]       NVARCHAR (50) NULL,
    [Apellidos]     NVARCHAR (50) NULL,
    [TotFactura]    MONEY         NULL,
    [TotRecibo]     MONEY         NULL,
    [Saldo]         MONEY         NULL,
    CONSTRAINT [SSMA_CC$Saldos$Apellidos$disallow_zero_length] CHECK (len([Apellidos])>(0)),
    CONSTRAINT [SSMA_CC$Saldos$Nombres$disallow_zero_length] CHECK (len([Nombres])>(0)),
    CONSTRAINT [FK_Saldos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos].[TotFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos', @level2type = N'COLUMN', @level2name = N'TotFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos].[TotRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos', @level2type = N'COLUMN', @level2name = N'TotRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Saldos].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Saldos', @level2type = N'COLUMN', @level2name = N'Saldo';

