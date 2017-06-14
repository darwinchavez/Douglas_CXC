CREATE TABLE [dbo].[REstCta] (
    [CodigoCliente] INT           NULL,
    [Nombres]       NVARCHAR (50) NULL,
    [Apellidos]     NVARCHAR (50) NULL,
    [Fecha]         DATETIME2 (0) NULL,
    [NFactura]      NVARCHAR (25) NULL,
    [MFactura]      MONEY         NULL,
    [NRecibo]       NVARCHAR (25) NULL,
    [MRecibo]       MONEY         NULL,
    [TipoVenta]     NVARCHAR (14) NULL,
    [Saldo]         MONEY         NULL,
    CONSTRAINT [SSMA_CC$REstCta$Apellidos$disallow_zero_length] CHECK (len([Apellidos])>(0)),
    CONSTRAINT [SSMA_CC$REstCta$NFactura$disallow_zero_length] CHECK (len([NFactura])>(0)),
    CONSTRAINT [SSMA_CC$REstCta$Nombres$disallow_zero_length] CHECK (len([Nombres])>(0)),
    CONSTRAINT [SSMA_CC$REstCta$NRecibo$disallow_zero_length] CHECK (len([NRecibo])>(0)),
    CONSTRAINT [SSMA_CC$REstCta$TipoVenta$disallow_zero_length] CHECK (len([TipoVenta])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[Fecha]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'Fecha';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[NFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'NFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[MFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'MFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[NRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'NRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[MRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'MRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[TipoVenta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'TipoVenta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[REstCta].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'REstCta', @level2type = N'COLUMN', @level2name = N'Saldo';

