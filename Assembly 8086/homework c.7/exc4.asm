.MODEL small
.STACK
.DATA
  var1 db 39
  var2 db 7
  res db ?
  rem db ?
.CODE
  mov ax, @data
  mov ds, ax
  
  mov ax, 0
  
  mov al, [var1]
  idiv [var2]
  
  mov [res], al
  mov [rem], ah
  
  
END

