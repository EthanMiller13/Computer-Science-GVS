.MODEL small
.STACK 100h
.DATA
  num1 db 5
  num2 db 5
  num3 db ?
.CODE
  mov ax, @data
  mov ds, ax
  mov al, [num1]
  add al, [num2]
  mov [num3], al
END

