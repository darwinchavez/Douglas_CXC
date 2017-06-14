CREATE TABLE [dbo].[TotalCreditos] (
    [CodigoCliente]  INT        NULL,
    [Total_Creditos] FLOAT (53) NULL,
    CONSTRAINT [FK_TotalCreditos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
CREATE NONCLUSTERED INDEX [TotalCreditos$TotalCreditosCodigoCliente]
    ON [dbo].[TotalCreditos]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalCreditos].[TotalCreditosCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalCreditos', @level2type = N'INDEX', @level2name = N'TotalCreditos$TotalCreditosCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalCreditos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalCreditos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalCreditos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalCreditos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[TotalCreditos].[Total_Creditos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TotalCreditos', @level2type = N'COLUMN', @level2name = N'Total_Creditos';

