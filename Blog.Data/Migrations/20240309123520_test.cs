using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3dfee43f-131c-40f3-83b4-f782e768a349"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("ce16ea73-4333-4c99-9538-16997c3e4bec"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("0c8d6d27-6684-4d5d-9548-9e209d68f360"), new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2024, 3, 9, 15, 35, 20, 525, DateTimeKind.Local).AddTicks(31), null, null, new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"), 20 },
                    { new Guid("49752ffa-d0dd-4407-abf8-c5cef21a788e"), new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2024, 3, 9, 15, 35, 20, 525, DateTimeKind.Local).AddTicks(40), null, null, new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"), false, null, null, "resim", new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b9de5b7-9c7b-47be-83f7-a3bc6c9261fb"),
                column: "ConcurrencyStamp",
                value: "90948e70-53e4-4113-a57d-fede6df43142");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("880a75ab-3fa5-47fc-a721-5a5e5ee257eb"),
                column: "ConcurrencyStamp",
                value: "c60008ea-726e-4494-823d-0f34dc5218a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c24cfeb2-4715-4185-883d-01a4995c139b"),
                column: "ConcurrencyStamp",
                value: "1aa401d5-859a-40bc-ad3a-89c573f4f92b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "000ea5e3-db50-4fe6-848a-7a5451c67580", "AQAAAAEAACcQAAAAEGRVFJ23PhAc9DJuwuFu+m7GtBl+kCQVUNd8IS23a7cfMAvSNitV8tRgpF47giQVNQ==", "71cf034b-867a-40db-bc6b-896520029bcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef3500b-86fd-4ad3-b685-1bdd526711c5", "AQAAAAEAACcQAAAAEMzZypT7VdwjUWwWlM6li5z1zYHyuOeqpN3phfr4fCpUjSwWiiUXEjusRUDKjkgEzw==", "9d475ea4-1282-4976-b9d5-5be31296dff5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 9, 15, 35, 20, 525, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 9, 15, 35, 20, 525, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 9, 15, 35, 20, 525, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"),
                column: "CreatedDate",
                value: new DateTime(2024, 3, 9, 15, 35, 20, 525, DateTimeKind.Local).AddTicks(1433));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0c8d6d27-6684-4d5d-9548-9e209d68f360"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("49752ffa-d0dd-4407-abf8-c5cef21a788e"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("3dfee43f-131c-40f3-83b4-f782e768a349"), new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(8060), null, null, new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"), false, null, null, "resim", new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"), 15 },
                    { new Guid("ce16ea73-4333-4c99-9538-16997c3e4bec"), new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.\r\n\r\nWhy do we use it?\r\nIt is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).\r\n\r\n\r\nWhere does it come from?\r\nContrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of \"de Finibus Bonorum et Malorum\" (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, \"Lorem ipsum dolor sit amet..\", comes from a line in section 1.10.32.\r\n\r\nThe standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from \"de Finibus Bonorum et Malorum\" by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.", "Admin test", new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(8053), null, null, new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"), false, null, null, "Asp.net Core Deneme Makalesi 1", new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"), 20 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("3b9de5b7-9c7b-47be-83f7-a3bc6c9261fb"),
                column: "ConcurrencyStamp",
                value: "36b994a3-edd9-4088-be19-61474d8fc796");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("880a75ab-3fa5-47fc-a721-5a5e5ee257eb"),
                column: "ConcurrencyStamp",
                value: "a6db749c-d87d-47e0-b703-2ee954fdc390");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c24cfeb2-4715-4185-883d-01a4995c139b"),
                column: "ConcurrencyStamp",
                value: "718d3b80-a366-42f8-a14a-7d41b93c51d6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("060fe724-b2c7-485f-8b02-45d5d1d7614e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea539547-13e9-44bb-bbff-1b2fd093cf12", "AQAAAAEAACcQAAAAEOKJw7qKlKDX5EjRqc5tbtCqfuQOiqh0DUoYJ5VMT4BLRnsxoes9tMjiFWSHerM21Q==", "c638a739-4ac8-4a72-b63b-77e4982e6832" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("77db4b55-26af-4b76-affe-fed6c4b22164"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ccdea36-1b35-4544-8bb1-424805ac9794", "AQAAAAEAACcQAAAAEF4HfytgD5IHFK05lSBZkNCOP2gqCTm9ISa0xx95rqYhvDEuw6hAOZaQopHQWSE2OQ==", "4926f5a7-3307-4813-862e-2acb1b493746" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b925c471-3601-46d5-84f5-350a27dc52e3"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e5f29edd-e8e1-4e47-a66d-ec9304d1a78b"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9673));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("5a4757c3-632a-4dfb-b850-be41163a5c0c"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("9afe33e7-79c2-4575-9bb1-5e3c66009ecf"),
                column: "CreatedDate",
                value: new DateTime(2024, 1, 17, 17, 24, 19, 554, DateTimeKind.Local).AddTicks(9748));
        }
    }
}
