local dap = require('dap')

dap.adapters.coreclr = {
  type = 'executable',
  command = '/home/fanky/.local/share/nvim/mason/bin/netcoredbg',
  args = {'--interpreter=vscode'}
}

dap.configurations.cs = {
  {
    type = "coreclr",
    name = "launch - netcoredbg",
    request = "launch",
    program = function()
        return vim.fn.input('Path to dll', vim.fn.getcwd() .. '/bin/Debug/net9.0/', 'file')
    end,
  },
}

-- Signs
vim.fn.sign_define('DapBreakpoint', {text='🛑', texthl='', linehl='', numhl=''})
vim.fn.sign_define('DapStopped', {text='⏩', texthl='', linehl='', numhl=''})
