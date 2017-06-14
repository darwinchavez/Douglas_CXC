CREATE TABLE [dbo].[Abonos] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente] INT           NULL,
    [FechaAbono]    DATETIME2 (0) NULL,
    [Num_Recibo]    NVARCHAR (15) NOT NULL,
    [Monto]         FLOAT (53)    NULL,
    [Tipo]          NVARCHAR (15) NULL,
    CONSTRAINT [Abonos$PrimaryKey] PRIMARY KEY CLUSTERED ([Num_Recibo] ASC),
    CONSTRAINT [FK_Abonos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[FechaAbono]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'COLUMN', @level2name = N'FechaAbono';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[Num_Recibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'COLUMN', @level2name = N'Num_Recibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'COLUMN', @level2name = N'Tipo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Abonos].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Abonos', @level2type = N'CONSTRAINT', @level2name = N'Abonos$PrimaryKey';

