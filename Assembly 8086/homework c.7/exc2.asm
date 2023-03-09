.MODEL small
.STACK
.DATA
  Array db 01, 02, 03, 04, 05, 06
.CODE
  mov ax, @data
  mov ds, ax
  
  mov ax, 0
  
  add al, [Array]
  add al, [Array+1]
  add al, [Array+2]
  add al, [Array+3]
  add al, [Array+4]
  add al, [Array+5]
END

