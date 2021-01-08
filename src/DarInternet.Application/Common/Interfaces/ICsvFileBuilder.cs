﻿using DarInternet.Application.Features.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace DarInternet.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
