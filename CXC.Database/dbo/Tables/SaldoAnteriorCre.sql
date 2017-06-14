CREATE TABLE [dbo].[SaldoAnteriorCre] (
    [CodigoCliente]  INT        NULL,
    [SalAntCre]      FLOAT (53) NULL,
    [SSMA_TimeStamp] ROWVERSION NOT NULL
);


GO
CREATE NONCLUSTERED INDEX [SaldoAnteriorCre$SaldoAnteriorCreCodigoCliente]
    ON [dbo].[SaldoAnteriorCre]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnteriorCre].[SaldoAnteriorCreCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnteriorCre', @level2type = N'INDEX', @level2name = N'SaldoAnteriorCre$SaldoAnteriorCreCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnteriorCre]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnteriorCre';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnteriorCre].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnteriorCre', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SaldoAnteriorCre].[SalAntCre]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SaldoAnteriorCre', @level2type = N'COLUMN', @level2name = N'SalAntCre';

