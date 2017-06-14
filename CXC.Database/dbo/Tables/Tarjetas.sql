CREATE TABLE [dbo].[Tarjetas] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente] INT           NULL,
    [FechaIngreso]  DATETIME2 (0) NULL,
    [Num_Lote]      NVARCHAR (15) NOT NULL,
    [Monto]         FLOAT (53)    NULL,
    [Tipo]          NVARCHAR (15) NULL,
    CONSTRAINT [Tarjetas$PrimaryKey] PRIMARY KEY CLUSTERED ([Num_Lote] ASC),
    CONSTRAINT [FK_Tarjetas_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [Tarjetas$Num_Recibo]
    ON [dbo].[Tarjetas]([Num_Lote] ASC);


GO
CREATE NONCLUSTERED INDEX [Tarjetas$TarjetasCodigoCliente]
    ON [dbo].[Tarjetas]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[Num_Recibo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'INDEX', @level2name = N'Tarjetas$Num_Recibo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[TarjetasCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'INDEX', @level2name = N'Tarjetas$TarjetasCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[FechaIngreso]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'COLUMN', @level2name = N'FechaIngreso';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[Num_Lote]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'COLUMN', @level2name = N'Num_Lote';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'COLUMN', @level2name = N'Tipo';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[Tarjetas].[PrimaryKey]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'Tarjetas', @level2type = N'CONSTRAINT', @level2name = N'Tarjetas$PrimaryKey';

