CREATE TABLE [dbo].[Clientes] (
    [CodigoCliente]  INT           NOT NULL,
    [Nombres]        NVARCHAR (50) NULL,
    [Apellidos]      NVARCHAR (50) NULL,
    [Limite_Credito] FLOAT (53)    DEFAULT ((0)) NULL,
    CONSTRAINT [Clientes$PrimaryKey] PRIMARY KEY CLUSTERED ([CodigoCliente] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Clientes]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Clientes';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Clientes].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Clientes', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Clientes].[Nombres]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Clientes', @level2type = N'COLUMN', @level2name = N'Nombres';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Clientes].[Apellidos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Clientes', @level2type = N'COLUMN', @level2name = N'Apellidos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Clientes].[Limite_Credito]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Clientes', @level2type = N'COLUMN', @level2name = N'Limite_Credito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Clientes].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Clientes', @level2type = N'CONSTRAINT', @level2name = N'Clientes$PrimaryKey';

