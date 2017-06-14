CREATE TABLE [dbo].[RestCtaClientes] (
    [CodigoCliente]  INT           NULL,
    [Nombres]        NVARCHAR (50) NULL,
    [Apellidos]      NVARCHAR (50) NULL,
    [Limite_Credito] FLOAT (53)    NULL,
    [Total_Creditos] FLOAT (53)    NULL,
    [Total_Abonos]   FLOAT (53)    NULL,
    [Saldo]          FLOAT (53)    NULL,
    CONSTRAINT [FK_RestCtaClientes_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[Limite_Credito]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'Limite_Credito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[Total_Creditos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'Total_Creditos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[Total_Abonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'Total_Abonos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RestCtaClientes].[Saldo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RestCtaClientes', @level2type = N'COLUMN', @level2name = N'Saldo';

