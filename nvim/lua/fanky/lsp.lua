config = {
  on_attach = function()
    print("This will run when the server attaches!")
  end,
}
vim.lsp.config('roslyn', config)
vim.lsp.enable('roslyn')
