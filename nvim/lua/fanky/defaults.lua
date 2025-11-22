local set = vim.opt

set.number = true
set.swapfile = false
set.autoindent = true
set.tabstop = 2
set.shiftwidth = 2
set.softtabstop = 2
set.expandtab = true
vim.g.mapleader = ","

-- LSP - Diagnostics signs
vim.diagnostic.config({
  signs = {
    text = {
      [vim.diagnostic.severity.ERROR] = '❌',
      [vim.diagnostic.severity.WARN] = '⚠️',
      [vim.diagnostic.severity.HINT] = '👁️',
      [vim.diagnostic.severity.INFO] = '👉',
    },
  },
})
