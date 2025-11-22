config = {
  on_attach = function()
    print("This will run when the server attaches!")
  end,
}

vim.lsp.config('roslyn', config)
vim.lsp.enable('roslyn')

vim.lsp.config('lua_ls', config)
vim.lsp.enable('lua_ls')
