CREATE TABLE [dbo].[RegistrosSalAnt] (
    [CodigoCliente]    INT           NULL,
    [FechaTransaccion] DATETIME2 (0) NULL,
    [TipoTransaccion]  NVARCHAR (15) NULL,
    [Monto]            FLOAT (53)    NULL,
    [SSMA_TimeStamp]   ROWVERSION    NOT NULL,
    CONSTRAINT [SSMA_CC$RegistrosSalAnt$TipoTransaccion$disallow_zero_length] CHECK (len([TipoTransaccion])>(0))
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosSalAnt]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosSalAnt';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosSalAnt].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosSalAnt', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosSalAnt].[FechaTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosSalAnt', @level2type = N'COLUMN', @level2name = N'FechaTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosSalAnt].[TipoTransaccion]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosSalAnt', @level2type = N'COLUMN', @level2name = N'TipoTransaccion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RegistrosSalAnt].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RegistrosSalAnt', @level2type = N'COLUMN', @level2name = N'Monto';

