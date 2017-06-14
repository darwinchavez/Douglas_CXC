CREATE TABLE [dbo].[TSaldoAnterior] (
    [CodigoCliente]  INT        NULL,
    [SalAntCre]      FLOAT (53) NULL,
    [SalAnt]         FLOAT (53) NULL,
    [SaldoAnterior]  FLOAT (53) NULL,
    [SSMA_TimeStamp] ROWVERSION NOT NULL
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TSaldoAnterior]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSaldoAnterior';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TSaldoAnterior].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSaldoAnterior', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TSaldoAnterior].[SalAntCre]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSaldoAnterior', @level2type = N'COLUMN', @level2name = N'SalAntCre';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TSaldoAnterior].[SalAnt]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSaldoAnterior', @level2type = N'COLUMN', @level2name = N'SalAnt';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TSaldoAnterior].[SaldoAnterior]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSaldoAnterior', @level2type = N'COLUMN', @level2name = N'SaldoAnterior';

