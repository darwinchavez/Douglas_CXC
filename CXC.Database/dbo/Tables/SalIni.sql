CREATE TABLE [dbo].[SalIni] (
    [Numero]         INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente]  INT           NULL,
    [Fecha]          DATETIME2 (0) NULL,
    [NFactura]       NVARCHAR (25) NULL,
    [MFactura]       FLOAT (53)    NULL,
    [NRecibo]        NVARCHAR (25) NULL,
    [MRecibo]        FLOAT (53)    NULL,
    [TipoVenta]      NVARCHAR (14) NULL,
    [SSMA_TimeStamp] ROWVERSION    NOT NULL,
    CONSTRAINT [SSMA_CC$SalIni$NFactura$disallow_zero_length] CHECK (len([NFactura])>(0)),
    CONSTRAINT [SSMA_CC$SalIni$NRecibo$disallow_zero_length] CHECK (len([NRecibo])>(0)),
    CONSTRAINT [SSMA_CC$SalIni$TipoVenta$disallow_zero_length] CHECK (len([TipoVenta])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[Fecha]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'Fecha';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[NFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'NFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[MFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'MFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[NRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'NRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[MRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'MRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalIni].[TipoVenta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalIni', @level2type = N'COLUMN', @level2name = N'TipoVenta';

