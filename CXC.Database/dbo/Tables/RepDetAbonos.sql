CREATE TABLE [dbo].[RepDetAbonos] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente] INT           NULL,
    [FechaAbono]    DATETIME2 (0) NULL,
    [Num_Recibo]    NVARCHAR (15) NULL,
    [Monto]         FLOAT (53)    NULL,
    [Tipo]          NVARCHAR (15) NULL,
    CONSTRAINT [SSMA_CC$RepDetAbonos$Num_Recibo$disallow_zero_length] CHECK (len([Num_Recibo])>(0)),
    CONSTRAINT [SSMA_CC$RepDetAbonos$Tipo$disallow_zero_length] CHECK (len([Tipo])>(0)),
    CONSTRAINT [FK_RepDetAbonos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
CREATE NONCLUSTERED INDEX [RepDetAbonos$RepDetAbonosCodigoCliente]
    ON [dbo].[RepDetAbonos]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[RepDetAbonosCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'INDEX', @level2name = N'RepDetAbonos$RepDetAbonosCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[FechaAbono]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'COLUMN', @level2name = N'FechaAbono';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[Num_Recibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'COLUMN', @level2name = N'Num_Recibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetAbonos].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetAbonos', @level2type = N'COLUMN', @level2name = N'Tipo';

