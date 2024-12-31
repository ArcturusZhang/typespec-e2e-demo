## API Report File for "@notabrand/todo-non-branded"

> Do not edit this file. It is a report generated by [API Extractor](https://api-extractor.com/).

```ts

import { ClientOptions } from '@typespec/ts-http-runtime';
import { KeyCredential } from '@typespec/ts-http-runtime';
import { OperationOptions } from '@typespec/ts-http-runtime';
import { Pipeline } from '@typespec/ts-http-runtime';

// @public
export type ContinuablePage<TElement, TPage = TElement[]> = TPage & {
    continuationToken?: string;
};

// @public
interface File_2 {
    // (undocumented)
    contents: Uint8Array;
    // (undocumented)
    contentType?: string;
    // (undocumented)
    filename?: string;
}
export { File_2 as File }

// @public
export interface FileAttachmentMultipartRequest {
    // (undocumented)
    contents: File_2;
}

// @public
export interface PagedAsyncIterableIterator<TElement, TPage = TElement[], TPageSettings extends PageSettings = PageSettings> {
    [Symbol.asyncIterator](): PagedAsyncIterableIterator<TElement, TPage, TPageSettings>;
    byPage: (settings?: TPageSettings) => AsyncIterableIterator<ContinuablePage<TElement, TPage>>;
    next(): Promise<IteratorResult<TElement>>;
}

// @public
export interface PageSettings {
    continuationToken?: string;
}

// @public
export interface PageTodoAttachment {
    // (undocumented)
    items: TodoAttachment[];
}

// @public
export interface TodoAttachment {
    contents: Uint8Array;
    filename: string;
    mediaType: string;
}

// @public (undocumented)
export class TodoClient {
    constructor(endpointParam: string, credential: KeyCredential, options?: TodoClientOptionalParams);
    readonly pipeline: Pipeline;
    readonly todoItems: TodoItemsOperations;
    readonly users: UsersOperations;
}

// @public
export interface TodoClientOptionalParams extends ClientOptions {
}

// @public
export interface TodoItem {
    assignedTo?: number;
    readonly completedAt?: Date;
    readonly createdAt: Date;
    readonly createdBy: number;
    description?: string;
    // (undocumented)
    dummy?: string;
    readonly id: number;
    // (undocumented)
    labels?: TodoLabels;
    status: "NotStarted" | "InProgress" | "Completed";
    title: string;
    readonly updatedAt: Date;
}

// @public
export interface ToDoItemMultipartRequest {
    // (undocumented)
    attachments?: File_2[];
    // (undocumented)
    item: TodoItem;
}

// @public
export interface TodoItemPatch {
    assignedTo?: number | null;
    description?: string | null;
    status?: "NotStarted" | "InProgress" | "Completed";
    title?: string;
}

// @public
export interface TodoItemsAttachmentsCreateFileAttachmentOptionalParams extends OperationOptions {
}

// @public
export interface TodoItemsAttachmentsCreateJsonAttachmentOptionalParams extends OperationOptions {
}

// @public
export interface TodoItemsAttachmentsListOptionalParams extends OperationOptions {
}

// @public
export interface TodoItemsAttachmentsOperations {
    // (undocumented)
    createFileAttachment: (itemId: number, body: FileAttachmentMultipartRequest, options?: TodoItemsAttachmentsCreateFileAttachmentOptionalParams) => Promise<void>;
    // (undocumented)
    createJsonAttachment: (itemId: number, contents: TodoAttachment, options?: TodoItemsAttachmentsCreateJsonAttachmentOptionalParams) => Promise<void>;
    // (undocumented)
    list: (itemId: number, options?: TodoItemsAttachmentsListOptionalParams) => PagedAsyncIterableIterator<TodoAttachment>;
}

// @public
export interface TodoItemsCreateFormOptionalParams extends OperationOptions {
}

// @public
export interface TodoItemsCreateJsonOptionalParams extends OperationOptions {
    // (undocumented)
    attachments?: TodoAttachment[];
}

// @public
export interface TodoItemsDeleteOptionalParams extends OperationOptions {
}

// @public
export interface TodoItemsGetOptionalParams extends OperationOptions {
}

// @public
export interface TodoItemsListOptionalParams extends OperationOptions {
    limit?: number;
    offset?: number;
}

// @public
export interface TodoItemsOperations {
    // (undocumented)
    attachments: TodoItemsAttachmentsOperations;
    // (undocumented)
    createForm: (body: ToDoItemMultipartRequest, options?: TodoItemsCreateFormOptionalParams) => Promise<{
        id: number;
        title: string;
        createdBy: number;
        assignedTo?: number;
        description?: string;
        status: "NotStarted" | "InProgress" | "Completed";
        createdAt: Date;
        updatedAt: Date;
        completedAt?: Date;
        labels?: TodoLabels;
    }>;
    // (undocumented)
    createJson: (item: TodoItem, options?: TodoItemsCreateJsonOptionalParams) => Promise<{
        id: number;
        title: string;
        createdBy: number;
        assignedTo?: number;
        description?: string;
        status: "NotStarted" | "InProgress" | "Completed";
        createdAt: Date;
        updatedAt: Date;
        completedAt?: Date;
        labels?: TodoLabels;
    }>;
    delete: (id: number, options?: TodoItemsDeleteOptionalParams) => Promise<void>;
    // (undocumented)
    get: (id: number, options?: TodoItemsGetOptionalParams) => Promise<{
        id: number;
        title: string;
        createdBy: number;
        assignedTo?: number;
        description?: string;
        status: "NotStarted" | "InProgress" | "Completed";
        createdAt: Date;
        updatedAt: Date;
        completedAt?: Date;
        labels?: TodoLabels;
    }>;
    // (undocumented)
    list: (options?: TodoItemsListOptionalParams) => PagedAsyncIterableIterator<TodoItem>;
    // (undocumented)
    update: (id: number, patch: TodoItemPatch, options?: TodoItemsUpdateOptionalParams) => Promise<{
        id: number;
        title: string;
        createdBy: number;
        assignedTo?: number;
        description?: string;
        status: "NotStarted" | "InProgress" | "Completed";
        createdAt: Date;
        updatedAt: Date;
        completedAt?: Date;
        labels?: TodoLabels;
    }>;
}

// @public
export interface TodoItemsUpdateOptionalParams extends OperationOptions {
}

// @public
export interface TodoLabelRecord {
    // (undocumented)
    color?: string;
    // (undocumented)
    name: string;
}

// @public
export type TodoLabels = string | string[] | TodoLabelRecord | TodoLabelRecord[];

// @public
export interface TodoPage {
    items: TodoItem[];
    nextLink?: string;
    pageSize: number;
    prevLink?: string;
    totalSize: number;
}

// @public
export interface User {
    email: string;
    readonly id: number;
    password: string;
    username: string;
}

// @public
export interface UsersCreateOptionalParams extends OperationOptions {
}

// @public
export interface UsersOperations {
    // (undocumented)
    create: (user: User, options?: UsersCreateOptionalParams) => Promise<{
        id: number;
        username: string;
        email: string;
        token: string;
    }>;
}

// (No @packageDocumentation comment for this package)

```