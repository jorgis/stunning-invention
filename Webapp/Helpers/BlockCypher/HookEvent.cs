namespace WebApp.Helpers.BlockCypher {
    public enum HookEvent {
        UnconfirmedTransaction,
        NewBlock,
        ConfirmedTransaction,
        TransactionConfirmation,
        DoubleSpendTransaction
    }
}
