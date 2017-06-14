CREATE TABLE [dbo].[TotalAbonos] (
    [CodigoCliente] INT        NULL,
    [Total_Abonos]  FLOAT (53) NULL,
    CONSTRAINT [FK_TotalAbonos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
CREATE NONCLUSTERED INDEX [TotalAbonos$TotalAbonosCodigoCliente]
    ON [dbo].[TotalAbonos]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalAbonos].[TotalAbonosCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalAbonos', @level2type = N'INDEX', @level2name = N'TotalAbonos$TotalAbonosCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalAbonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalAbonos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalAbonos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalAbonos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalAbonos].[Total_Abonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalAbonos', @level2type = N'COLUMN', @level2name = N'Total_Abonos';

