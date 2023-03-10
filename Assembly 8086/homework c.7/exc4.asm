.MODEL small
.STACK
.DATA
  var1 db 00000010b
  var2 db 00000001b
  res db ?
  rem db ?
.CODE
  mov ax, @data
  mov ds, ax
  
  mov ax, 0
  
  mov al, [var1]
  div [var2]
  
  mov [res], al
  mov [rem], ah
  
  
END

