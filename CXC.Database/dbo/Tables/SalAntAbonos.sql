CREATE TABLE [dbo].[SalAntAbonos] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente] INT           NULL,
    [FechaAbono]    DATETIME2 (0) NULL,
    [Num_Recibo]    NVARCHAR (15) NULL,
    [Monto]         FLOAT (53)    NULL,
    [Tipo]          NVARCHAR (15) NULL,
    CONSTRAINT [SSMA_CC$SalAntAbonos$Num_Recibo$disallow_zero_length] CHECK (len([Num_Recibo])>(0)),
    CONSTRAINT [SSMA_CC$SalAntAbonos$Tipo$disallow_zero_length] CHECK (len([Tipo])>(0)),
    CONSTRAINT [FK_SalAntAbonos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos].[FechaAbono]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos', @level2type = N'COLUMN', @level2name = N'FechaAbono';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos].[Num_Recibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos', @level2type = N'COLUMN', @level2name = N'Num_Recibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[SalAntAbonos].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SalAntAbonos', @level2type = N'COLUMN', @level2name = N'Tipo';

