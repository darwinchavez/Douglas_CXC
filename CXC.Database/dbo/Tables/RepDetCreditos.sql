CREATE TABLE [dbo].[RepDetCreditos] (
    [Numero]        INT           IDENTITY (1, 1) NOT NULL,
    [CodigoCliente] INT           NULL,
    [FechaCredito]  DATETIME2 (0) NULL,
    [Num_Factura]   NVARCHAR (15) NULL,
    [Monto]         FLOAT (53)    NULL,
    [Tipo]          NVARCHAR (15) NULL,
    CONSTRAINT [SSMA_CC$RepDetCreditos$Num_Factura$disallow_zero_length] CHECK (len([Num_Factura])>(0)),
    CONSTRAINT [SSMA_CC$RepDetCreditos$Tipo$disallow_zero_length] CHECK (len([Tipo])>(0)),
    CONSTRAINT [FK_RepDetCreditos_Clientes] FOREIGN KEY ([CodigoCliente]) REFERENCES [dbo].[Clientes] ([CodigoCliente])
);


GO
CREATE NONCLUSTERED INDEX [RepDetCreditos$RepDetCreditosCodigoCliente]
    ON [dbo].[RepDetCreditos]([CodigoCliente] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[RepDetCreditosCodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'INDEX', @level2name = N'RepDetCreditos$RepDetCreditosCodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[Numero]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'COLUMN', @level2name = N'Numero';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[CodigoCliente]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'COLUMN', @level2name = N'CodigoCliente';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[FechaCredito]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'COLUMN', @level2name = N'FechaCredito';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[Num_Factura]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'COLUMN', @level2name = N'Num_Factura';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[Monto]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'COLUMN', @level2name = N'Monto';


GO
EXECUTE sp_addextendedproperty @name = N'MS_SSMA_SOURCE', @value = N'CxcShell.[RepDetCreditos].[Tipo]', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'RepDetCreditos', @level2type = N'COLUMN', @level2name = N'Tipo';

