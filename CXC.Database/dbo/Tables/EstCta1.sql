CREATE TABLE [dbo].[EstCta1] (
    [CodigoCliente]  INT           NULL,
    [Numero]         INT           NULL,
    [Fecha]          DATETIME2 (0) NULL,
    [NFactura]       NVARCHAR (25) NULL,
    [MFactura]       FLOAT (53)    NULL,
    [NRecibo]        NVARCHAR (25) NULL,
    [MRecibo]        FLOAT (53)    NULL,
    [TipoVenta]      NVARCHAR (14) NULL,
    [Saldo]          FLOAT (53)    NULL,
    [SSMA_TimeStamp] ROWVERSION    NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [EstCta1$EstCta1CodigoCliente]
    ON [dbo].[EstCta1]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[EstCta1CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'INDEX', @level2name = N'EstCta1$EstCta1CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[Fecha]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'Fecha';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[NFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'NFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[MFactura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'MFactura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[NRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'NRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[MRecibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'MRecibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[TipoVenta]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'TipoVenta';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[EstCta1].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'EstCta1', @level2type = N'COLUMN', @level2name = N'Saldo';

