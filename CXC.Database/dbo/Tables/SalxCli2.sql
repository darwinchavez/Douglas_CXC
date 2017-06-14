CREATE TABLE [dbo].[SalxCli2] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente] INT           NULL,
    [Fecha]         DATETIME2 (0) NULL,
    [NFactura]      NVARCHAR (25) NULL,
    [MFactura]      MONEY         NULL,
    [NRecibo]       NVARCHAR (25) NULL,
    [MRecibo]       MONEY         NULL,
    [TipoVenta]     NVARCHAR (14) NULL,
    CONSTRAINT [SSMA_CC$SalxCli2$NFactura$disallow_zero_length] CHECK (len([NFactura])>(0)),
    CONSTRAINT [SSMA_CC$SalxCli2$NRecibo$disallow_zero_length] CHECK (len([NRecibo])>(0)),
    CONSTRAINT [SSMA_CC$SalxCli2$TipoVenta$disallow_zero_length] CHECK (len([TipoVenta])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[Fecha]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'Fecha';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[NFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'NFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[MFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'MFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[NRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'NRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[MRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'MRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalxCli2].[TipoVenta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalxCli2', @level2type = N'COLUMN', @level2name = N'TipoVenta';

